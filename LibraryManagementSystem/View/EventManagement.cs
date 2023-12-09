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
            LoadEventItemsAsync();
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
                var selectedItemVenue = selectedItem.SubItems[1].Text;
                var selectedItemOrganizer = selectedItem.SubItems[2].Text;

                var selectedItemDetails = _context.Events.FirstOrDefault(item => item.Title == selectedItemTitle && item.Venue == selectedItemVenue && item.Organizer == selectedItemOrganizer);

                adminManageEventTitleTextBox.Text = selectedItemDetails.Title;
                adminManageEventDescriptionTextBox.Text = selectedItemDetails.Description;
                adminManageEventDateTextBox.Text = selectedItemDetails.EventDate.ToString().Split(' ')[0];
                adminManageEventTimeTextBox.Text = selectedItemDetails.EventTime.ToString();
                adminManageEventVenueTextBox.Text = selectedItemDetails.Venue;
                adminManageEventOrganizerTextBox.Text = selectedItemDetails.Organizer;
                adminManageEventContactTextBox.Text = selectedItemDetails.ContactNo;
                adminManageEventEmailTextBox.Text = selectedItemDetails.Email;
            }
        }

        private async Task LoadEventItemsAsync()
        {
            var items = await _genericEntity.GetAllEntitiesAsync<Event>();

            var sortedItems = items.OrderBy(item => item.Title).ToList();

            adminManageEventListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                var listViewItem = new ListViewItem(item.Title);
                listViewItem.SubItems.Add(item.Venue);
                listViewItem.SubItems.Add(item.Organizer);
                listViewItem.Tag = item;

                adminManageEventListView.Items.Add(listViewItem);
            }
        }

        private async Task AddEventAsync()
        {
            var newEvent = new Event
            {
                Title = adminManageEventTitleTextBox.Text,
                Description = adminManageEventDescriptionTextBox.Text,
                EventDate = DateTime.Parse(adminManageEventDateTextBox.Text),
                EventTime = TimeSpan.Parse(adminManageEventTimeTextBox.Text),
                Venue = adminManageEventVenueTextBox.Text,
                Organizer = adminManageEventOrganizerTextBox.Text,
                ContactNo = adminManageEventContactTextBox.Text,
                Email = adminManageEventEmailTextBox.Text
            };

            await _genericEntity.AddEntityAsync(newEvent);
        }
    }
}
