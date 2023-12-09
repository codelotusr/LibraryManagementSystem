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
            try
            {
                if (string.IsNullOrWhiteSpace(adminManageEventTitleTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageEventDescriptionTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageEventDateTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageEventTimeTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageEventVenueTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageEventOrganizerTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageEventContactTextBox.Text) ||
                    string.IsNullOrWhiteSpace(adminManageEventEmailTextBox.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

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

                await _genericEntity.CreateEntityAsync(newEvent);
                await LoadEventItemsAsync(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding event: " + ex.Message);
            }
        }

        private async void adminManageEventCreateButton_Click(object sender, EventArgs e)
        {
            await AddEventAsync();
        }

        private async void adminManageEventUpdate_Click(object sender, EventArgs e)
        {
            await UpdateEventAsync();
        }

        private async Task UpdateEventAsync()
        {
            if (adminManageEventListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an event to update.");
                return;
            }

            var selectedItem = adminManageEventListView.SelectedItems[0];
            if (selectedItem.Tag is Event selectedEvent)
            {
                var confirmResult = MessageBox.Show("Are you sure to update this event?", "Confirm Update", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    selectedEvent.Title = adminManageEventTitleTextBox.Text;
                    selectedEvent.Description = adminManageEventDescriptionTextBox.Text;
                    selectedEvent.EventDate = DateTime.Parse(adminManageEventDateTextBox.Text);
                    selectedEvent.EventTime = TimeSpan.Parse(adminManageEventTimeTextBox.Text);
                    selectedEvent.Venue = adminManageEventVenueTextBox.Text;
                    selectedEvent.Organizer = adminManageEventOrganizerTextBox.Text;
                    selectedEvent.ContactNo = adminManageEventContactTextBox.Text;
                    selectedEvent.Email = adminManageEventEmailTextBox.Text;

                    try
                    {
                        await _genericEntity.UpdateEntityAsync(selectedEvent);
                        await LoadEventItemsAsync();
                        MessageBox.Show("Event updated.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating event: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selected item's tag is not an event.");
            }
        }

        private async void adminManageEventDeleteButton_Click(object sender, EventArgs e)
        {
            await DeleteEventAsync();
        }

        private async Task DeleteEventAsync()
        {
            if (adminManageEventListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }

            var selectedItem = adminManageEventListView.SelectedItems[0];
            if (selectedItem.Tag is Event selectedEvent)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        await _genericEntity.DeleteEntityAsync(selectedEvent);
                        await LoadEventItemsAsync();
                        MessageBox.Show("Event deleted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting event: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selected item's tag is not an event.");
            }
        }

    }
}
