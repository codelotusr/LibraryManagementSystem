using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class EventShowcase : Form
    {
        private readonly LibraryContext _context;
        private readonly GenericEntity _genericEntity;
        public EventShowcase()
        {
            InitializeComponent();
            _context = ServiceLocator.LibraryContext;
            _genericEntity = ServiceLocator.GenericEntity;
            LoadEventItemsAsync();
            setAllTextBoxesReadOnly();
        }

        private void eventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListView.SelectedItems.Count > 0)
            {
                var selectedItem = eventListView.SelectedItems[0];
                var selectedItemTitle = selectedItem.SubItems[0].Text;
                var selectedItemDate = selectedItem.SubItems[1].Text;
                var selectedItemTime = selectedItem.SubItems[2].Text;

                var selectedItemDetails = _context.Events.FirstOrDefault(item => item.Title == selectedItemTitle);

                if (selectedItemDetails != null &&
                    selectedItemDetails.EventDate.ToString().Split(' ')[0] == selectedItemDate &&
                    selectedItemDetails.EventTime.ToString() == selectedItemTime)
                {
                    eventTitleTextBox.Text = selectedItemDetails.Title;
                    eventDescriptionTextBox.Text = selectedItemDetails.Description;
                    eventDateTextBox.Text = selectedItemDetails.EventDate.ToString().Split(' ')[0];
                    eventTimeTextBox.Text = selectedItemDetails.EventTime.ToString();
                    eventVenueTextBox.Text = selectedItemDetails.Venue;
                    eventOrganizerTextBox.Text = selectedItemDetails.Organizer;
                    eventContactTextBox.Text = selectedItemDetails.ContactNo;
                }
            }
        }

        private async Task LoadEventItemsAsync()
        {
            var items = await _genericEntity.GetAllEntitiesAsync<Event>();

            var sortedItems = items.OrderBy(item => item.Title).ToList();

            eventListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                var listViewItem = new ListViewItem(item.Title);
                listViewItem.SubItems.Add(item.EventDate.ToString().Split(' ')[0]);
                listViewItem.SubItems.Add(item.EventTime.ToString());
                listViewItem.Tag = item;

                eventListView.Items.Add(listViewItem);
            }
        }

        private void setAllTextBoxesReadOnly()
        {
            eventTitleTextBox.ReadOnly = true;
            eventDescriptionTextBox.ReadOnly = true;
            eventDateTextBox.ReadOnly = true;
            eventTimeTextBox.ReadOnly = true;
            eventVenueTextBox.ReadOnly = true;
            eventOrganizerTextBox.ReadOnly = true;
            eventContactTextBox.ReadOnly = true;
        }

        private void eventReturnButton_Click(object sender, EventArgs e)
        {
            var previousForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            previousForm?.Show();
            this.Close();
        }
    }
}
