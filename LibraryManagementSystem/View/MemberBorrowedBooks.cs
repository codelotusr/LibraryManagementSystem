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
            setAllTextBoxesReadOnly();
        }

        private void memberBorrowedReturnButton_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private void memberBorrowedListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberBorrowedListView.SelectedItems.Count > 0)
            {
                var selectedItem = memberBorrowedListView.SelectedItems[0];
                if (selectedItem.Tag is BorrowedBookDetails details)
                {
                    memberBorrowedTitleTextBox.Text = details.Title;
                    memberBorrowedAuthorTextBox.Text = details.Author;
                    memberBorrowedIsbnTextBox.Text = details.ISBN;
                    memberBorrowedYearTextBox.Text = details.PublishedYear.ToString();
                    memberBorrowedCategoryTextBox.Text = details.Category;
                    memberBorrowedEditionTextBox.Text = details.Edition;
                    memberBorrowedDescriptionTextBox.Text = details.Description;
                }
            }
        }


        private async Task LoadBorrowedItemsAsync()
        {
            var borrowedItems = await _genericEntity.GetAllEntitiesAsync<BorrowingRecord>();
            var memberBorrowedItems = borrowedItems.Where(b => b.MemberId == _currentUserId && b.Status == BorrowingStatus.Borrowed);

            memberBorrowedListView.Items.Clear();

            foreach (var item in memberBorrowedItems)
            {
                var borrowedBookDetails = new BorrowedBookDetails
                {
                    Title = item.Book.Title,
                    Author = item.Book.Author,
                    ISBN = item.Book.ISBN,
                    PublishedYear = item.Book.PublishedYear,
                    Category = item.Book.Category,
                    Edition = item.Book.Edition,
                    Description = item.Book.Description,
                    BorrowedDate = item.BorrowedDate,
                    DueDate = item.DueDate
                };

                var listViewItem = new ListViewItem(borrowedBookDetails.Title);
                listViewItem.SubItems.Add(borrowedBookDetails.Author);
                listViewItem.SubItems.Add(borrowedBookDetails.BorrowedDate.ToShortDateString());
                listViewItem.SubItems.Add(borrowedBookDetails.DueDate.ToShortDateString());
                listViewItem.Tag = borrowedBookDetails;

                memberBorrowedListView.Items.Add(listViewItem);
            }
        }

        private void setAllTextBoxesReadOnly()
        {
            memberBorrowedTitleTextBox.ReadOnly = true;
            memberBorrowedAuthorTextBox.ReadOnly = true;
            memberBorrowedIsbnTextBox.ReadOnly = true;
            memberBorrowedYearTextBox.ReadOnly = true;
            memberBorrowedCategoryTextBox.ReadOnly = true;
            memberBorrowedEditionTextBox.ReadOnly = true;
            memberBorrowedDescriptionTextBox.ReadOnly = true;
        }

    }
}
