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
        private readonly GenericEntity _genericEntity;
        public AdminManageCatalog()
        {
            InitializeComponent();
            _genericEntity = ServiceLocator.GenericEntity;
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

        }
    }
}
