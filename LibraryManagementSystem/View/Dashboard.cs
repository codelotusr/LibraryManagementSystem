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
using LibraryManagementSystem.View;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberBorrowedBooks memberBorrowedBooks = new MemberBorrowedBooks();
            memberBorrowedBooks.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GlobalUserState.CurrentUserId = 0;
            var previousForm = Application.OpenForms.OfType<Login>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private void catalogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCatalog bookCatalog = new BookCatalog();
            bookCatalog.Show();
        }
    }
}
