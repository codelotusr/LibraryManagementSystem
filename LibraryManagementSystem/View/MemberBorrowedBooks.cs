using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.View
{
    public partial class MemberBorrowedBooks : Form
    {
        public MemberBorrowedBooks()
        {
            InitializeComponent();
        }

        private void memberBorrowedReturnButton_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private void memberBorrowedListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void LoadBorrowedItems()
        {
            
        }
    }
}
