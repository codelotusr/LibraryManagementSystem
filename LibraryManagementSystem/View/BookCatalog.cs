using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.View
{
    public partial class BookCatalog : Form
    {
        private LibraryContext _context;
        public BookCatalog()
        {
            InitializeComponent();
            _context = new LibraryContext();
            LoadData();
        }

        private void LoadData()
        {
            catalogListView.Items.Clear();

            var books = _context.Books.ToList();


            foreach (var book in books)
            {
                var item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.PublishedYear.ToString());

                catalogListView.Items.Add(item);
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
