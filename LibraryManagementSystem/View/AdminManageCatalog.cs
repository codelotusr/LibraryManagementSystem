using LibraryManagementSystem.EntityUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.View
{
    public partial class AdminManageCatalog : Form
    {
        private LibraryContext _context;
        private readonly GenericEntity _genericEntity;
        public AdminManageCatalog()
        {
            InitializeComponent();
            _genericEntity = ServiceLocator.GenericEntity;
            _context = ServiceLocator.LibraryContext;
            LoadCatalogItemsAsync().ConfigureAwait(false);
        }

        private async Task LoadCatalogItemsAsync()
        {
            var items = await _genericEntity.GetAllEntitiesAsync<Book>();

            var sortedItems = items.OrderBy(item => item.Title).ToList();

            adminManageCatalogListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                var listViewItem = new ListViewItem(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.PublishedYear.ToString());

                adminManageCatalogListView.Items.Add(listViewItem);
            }
        }


        private async Task AddBookAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(adminManageCatalogTitleTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogAuthorTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogIsbnTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogYearTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogCategoryTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogDescriptionTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogQuantityTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogPriceTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogEditionTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageCatalogLocationTextBox.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!int.TryParse(adminManageCatalogYearTextBox.Text, out var year))
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                if (!int.TryParse(adminManageCatalogQuantityTextBox.Text, out var quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                if (!int.TryParse(adminManageCatalogPriceTextBox.Text, out var price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                if (year < 0 || year > 9999)
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                if (quantity < 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                if (price < 0)
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                if (adminManageCatalogListView.Items.Cast<ListViewItem>().Any(item =>
                        item.SubItems[0].Text == adminManageCatalogTitleTextBox.Text &&
                        item.SubItems[1].Text == adminManageCatalogAuthorTextBox.Text &&
                        item.SubItems[2].Text == adminManageCatalogYearTextBox.Text))
                {
                    MessageBox.Show("Book already exists.");
                    return;
                }

                var newBook = new Book
                {
                    Title = adminManageCatalogTitleTextBox.Text,
                    Author = adminManageCatalogAuthorTextBox.Text,
                    ISBN = adminManageCatalogIsbnTextBox.Text,
                    PublishedYear = int.Parse(adminManageCatalogYearTextBox.Text),
                    Category = adminManageCatalogCategoryTextBox.Text,
                    Description = adminManageCatalogDescriptionTextBox.Text,
                    Quantity = int.Parse(adminManageCatalogQuantityTextBox.Text),
                    Price = int.Parse(adminManageCatalogPriceTextBox.Text),
                    Edition = adminManageCatalogEditionTextBox.Text,
                    ShelfLocation = adminManageCatalogLocationTextBox.Text
                };

                await _genericEntity.CreateEntityAsync(newBook);
                await LoadCatalogItemsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }

        private async Task DeleteBookAsync()
        {
            if (adminManageCatalogListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            var selectedItem = adminManageCatalogListView.SelectedItems[0];
            if (selectedItem.Tag is Book selectedBook)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        await _genericEntity.DeleteEntityAsync(selectedBook);
                        await LoadCatalogItemsAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting book: " + ex.Message);
                    }
                }
            }
        }




        private async void adminManageCatalogCreateButton_Click(object sender, EventArgs e)
        {
            await AddBookAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<AdminPanel>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private async void adminManageCatalogDeleteButton_Click(object sender, EventArgs e)
        {
            await DeleteBookAsync();
        }

        private void adminManageCatalogListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminManageCatalogListView.SelectedItems.Count > 0)
            {
                var selectedItem = adminManageCatalogListView.SelectedItems[0];
                var selectedItemTitle = selectedItem.SubItems[0].Text;
                var selectedItemAuthor = selectedItem.SubItems[1].Text;
                var selectedItemYear = selectedItem.SubItems[2].Text;

                var selectedItemDetails = _context.Books.FirstOrDefault(item =>
                                                          item.Title == selectedItemTitle && item.Author == selectedItemAuthor &&
                                                                                                                   item.PublishedYear.ToString() == selectedItemYear);

                adminManageCatalogTitleTextBox.Text = selectedItemDetails.Title;
                adminManageCatalogAuthorTextBox.Text = selectedItemDetails.Author;
                adminManageCatalogIsbnTextBox.Text = selectedItemDetails.ISBN;
                adminManageCatalogYearTextBox.Text = selectedItemDetails.PublishedYear.ToString();
                adminManageCatalogCategoryTextBox.Text = selectedItemDetails.Category;
                adminManageCatalogDescriptionTextBox.Text = selectedItemDetails.Description;
                adminManageCatalogQuantityTextBox.Text = selectedItemDetails.Quantity.ToString();
                adminManageCatalogPriceTextBox.Text = selectedItemDetails.Price.ToString();
                adminManageCatalogEditionTextBox.Text = selectedItemDetails.Edition;
                adminManageCatalogLocationTextBox.Text = selectedItemDetails.ShelfLocation;

            }
        }
    }
}
