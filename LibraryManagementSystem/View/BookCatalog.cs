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
    public partial class BookCatalog : Form
    {
        private LibraryContext _context;
        private readonly GenericEntity _genericEntity;
        public BookCatalog()
        {
            InitializeComponent();
            _context = ServiceLocator.LibraryContext;
            _genericEntity = ServiceLocator.GenericEntity;
            LoadCatalogItemsAsync();
            setAllTextBoxesReadOnly();
        }

        private async Task LoadCatalogItemsAsync()
        {
            var items = await _genericEntity.GetAllEntitiesAsync<Book>();

            var sortedItems = items.OrderBy(item => item.Title).ToList();

            catalogListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                var listViewItem = new ListViewItem(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.PublishedYear.ToString());

                catalogListView.Items.Add(listViewItem);
            }
        }

        private async void rentABookButton_Click(object sender, EventArgs e)
        {
            if (catalogListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book to rent");
                return;
            }

            var selectedItem = catalogListView.SelectedItems[0];
            var title = selectedItem.SubItems[0].Text;
            var author = selectedItem.SubItems[1].Text;
            var publishedYear = selectedItem.SubItems[2].Text;

            var selectedItemDetails = _context.Books.FirstOrDefault(item => item.Title == title && item.Author == author && item.PublishedYear.ToString() == publishedYear);
            if (selectedItemDetails == null)
            {
                MessageBox.Show("Selected book not found");
                return;
            }

            int currentMemberId = GlobalUserState.CurrentUserId;

            var borrowingRecord = new BorrowingRecord
            {
                BookId = selectedItemDetails.Id,
                MemberId = currentMemberId,
                Status = BorrowingStatus.Borrowed,
                BorrowedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(14)
            };

            try
            {
                await _genericEntity.CreateEntityAsync(borrowingRecord);
                MessageBox.Show("Book rented successfully");
            }
            catch
            {
                MessageBox.Show("An error occurred while renting the book");
            }
        }

        private void catalogListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catalogListView.SelectedItems.Count > 0)
            {
                var selectedItem = catalogListView.SelectedItems[0];
                var selectedItemTitle = selectedItem.SubItems[0].Text;
                var selectedItemAuthor = selectedItem.SubItems[1].Text;
                var selectedItemYear = selectedItem.SubItems[2].Text;

                var selectedItemDetails = _context.Books.FirstOrDefault(item =>
                                       item.Title == selectedItemTitle && item.Author == selectedItemAuthor &&
                                                          item.PublishedYear.ToString() == selectedItemYear);

                catalogTitleTextBox.Text = selectedItemDetails.Title;
                catalogAuthorTextBox.Text = selectedItemDetails.Author;
                catalogIsbnTextBox.Text = selectedItemDetails.ISBN;
                catalogYearTextBox.Text = selectedItemDetails.PublishedYear.ToString();
                catalogCategoryTextBox.Text = selectedItemDetails.Category;
                catalogEditionTextBox.Text = selectedItemDetails.Edition;
                catalogDescriptionTextBox.Text = selectedItemDetails.Description;
            }
        }

        private void BookCatalog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private void setAllTextBoxesReadOnly()
        {
            catalogTitleTextBox.ReadOnly = true;
            catalogAuthorTextBox.ReadOnly = true;
            catalogIsbnTextBox.ReadOnly = true;
            catalogYearTextBox.ReadOnly = true;
            catalogCategoryTextBox.ReadOnly = true;
            catalogEditionTextBox.ReadOnly = true;
            catalogDescriptionTextBox.ReadOnly = true;
        }

        public List<Book> SearchBooks(string keyword, bool sortByTitle = true, int maxResults = 10)
        {
            var query = _context.Books.Where(book => book.Title.Contains(keyword) || book.Author.Contains(keyword));

            if (sortByTitle)
            {
                query = query.OrderBy(book => book.Title);
            }

            return query.Take(maxResults).ToList();
        }
    }
}
