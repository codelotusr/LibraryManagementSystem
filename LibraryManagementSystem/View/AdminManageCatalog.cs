using LibraryManagementSystem.EntityUtils;
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
    public partial class AdminManageCatalog : Form
    {
        private readonly GenericEntity _genericEntity;
        public AdminManageCatalog()
        {
            InitializeComponent();
            _genericEntity = ServiceLocator.GenericEntity;
        }

        private void adminManageCatalogListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
