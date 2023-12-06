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
            adminManageCatalogListView.Columns.Add("Title", 200);
            adminManageCatalogListView.Columns.Add("Author", 150);
            LoadCatalogItemsAsync().ConfigureAwait(false);
        }

        private async Task LoadCatalogItemsAsync()
        {
            var items = await _genericEntity.GetAllEntitiesAsync<Book>();

            adminManageCatalogListView.Items.Clear();

            foreach (var item in items)
            {
                var listViewItem = new ListViewItem((string)item.Title);
                listViewItem.SubItems.Add((string)item.Author);

                adminManageCatalogListView.Items.Add(listViewItem);
                adminManageCatalogListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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

        private async void adminManageCatalogCreateButton_Click(object sender, EventArgs e)
        {
            await AddBookAsync();
        }

        private void adminManageCatalogListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
