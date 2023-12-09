using System;
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
    public partial class EventManagement : Form
    {
        private readonly LibraryContext _context;
        private readonly GenericEntity _genericEntity;

        public EventManagement()
        {
            InitializeComponent();
            _context = ServiceLocator.LibraryContext;
            _genericEntity = ServiceLocator.GenericEntity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<AdminPanel>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }

        private void adminManageEventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminManageEventListView.SelectedItems.Count > 0)
            {
                var selectedItem = adminManageEventListView.SelectedItems[0];
                var selectedItemTitle = selectedItem.SubItems[0].Text;
                var selectedItemDate = selectedItem.SubItems[1].Text;
                var selectedItemTime = selectedItem.SubItems[2].Text;

                var selectedItemDetails = _context.Events.FirstOrDefault(item =>
                                       item.Title == selectedItemTitle && item.EventDate.ToString() == selectedItemDate &&
                                                          item.EventTime.ToString() == selectedItemTime);

                adminManageEventTitleTextBox.Text = selectedItemDetails.Title;
                adminManageEventDescriptionTextBox.Text = selectedItemDetails.Description;
                adminManageEventDateTextBox.Text = selectedItemDetails.EventDate.ToString();
                adminManageEventTimeTextBox.Text = selectedItemDetails.EventTime.ToString();
                adminManageEventVenueTextBox.Text = selectedItemDetails.Venue;
                adminManageEventOrganizerTextBox.Text = selectedItemDetails.Organizer;
                adminManageEventContactTextBox.Text = selectedItemDetails.ContactNo;
                adminManageEventEmailTextBox.Text = selectedItemDetails.Email;
            }
        }
    }
}
