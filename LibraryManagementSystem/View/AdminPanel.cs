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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageCatalog adminManageCatalog = new AdminManageCatalog();
            adminManageCatalog.Show();
        }

        private void adminPanelManageEventsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventManagement eventManagement = new EventManagement();
            eventManagement.Show();
        }

        private void adminPanelReturnButton_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private void adminPanelManageFinesButton_Click(object sender, EventArgs e)
        {

        }

        private void adminPanelManageUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
