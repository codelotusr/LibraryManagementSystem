﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void catalogListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookCatalog_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }
    }
}
