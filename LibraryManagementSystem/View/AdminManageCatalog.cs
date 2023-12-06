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

            adminManageCatalogListView.Items.Clear();

            foreach (var item in items)
            {
                var listViewItem = new ListViewItem((string)item.Title);
                listViewItem.SubItems.Add((string)item.Author);

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

                };

                await _genericEntity.CreateEntityAsync(newBook);
                await LoadCatalogItemsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }



        private void adminManageCatalogListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminManageCatalogCreateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
