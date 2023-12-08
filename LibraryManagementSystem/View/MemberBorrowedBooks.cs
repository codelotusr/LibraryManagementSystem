using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Core;
using LibraryManagementSystem.EntityUtils;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.View
{
    public partial class MemberBorrowedBooks : Form
    {
        private readonly GenericEntity _genericEntity;
        private readonly int _currentUserId;
        private readonly LibraryContext _context;
        public MemberBorrowedBooks()
        {
            InitializeComponent();
            _genericEntity = ServiceLocator.GenericEntity;
            _currentUserId = GlobalUserState.CurrentUserId;
            LoadBorrowedItemsAsync();
        }

        private void memberBorrowedReturnButton_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private async void memberBorrowedListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberBorrowedListView.SelectedItems.Count > 0)
            {
                var selectedItem = memberBorrowedListView.SelectedItems[0];
                var selectedItemTitle = selectedItem.SubItems[0].Text;
                var selectedItemAuthor = selectedItem.SubItems[1].Text;

                var selectedItemDetails = _context.Books.FirstOrDefault(item =>
                    item.Title == selectedItemTitle && item.Author == selectedItemAuthor);

                memberBorrowedTitleTextBox.Text = selectedItemDetails.Title;
                memberBorrowedAuthorTextBox.Text = selectedItemDetails.Author;
                memberBorrowedIsbnTextBox.Text = selectedItemDetails.ISBN;
                memberBorrowedYearTextBox.Text = selectedItemDetails.PublishedYear.ToString();
                memberBorrowedCategoryTextBox.Text = selectedItemDetails.Category;
                memberBorrowedEditionTextBox.Text = selectedItemDetails.Edition;
                memberBorrowedDescriptionTextBox.Text = selectedItemDetails.Description;
            }
        }

        private async void LoadBorrowedItemsAsync()
        {
            var borrowedItems = await _genericEntity.GetAllEntitiesAsync<BorrowingRecord>();
            var memberBorrowedItems = borrowedItems.Where(b => b.MemberId == _currentUserId && b.Status == BorrowingStatus.Borrowed);

            memberBorrowedListView.Items.Clear();

            foreach (var item in memberBorrowedItems)
            {
                var listViewItem = new ListViewItem(item.Book.Title);
                listViewItem.SubItems.Add(item.Book.Author);
                listViewItem.SubItems.Add(item.BorrowedDate.ToShortDateString());
                listViewItem.SubItems.Add(item.DueDate.ToShortDateString());

                memberBorrowedListView.Items.Add(listViewItem);
            }

        }
    }
}
