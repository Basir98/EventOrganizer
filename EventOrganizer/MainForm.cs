using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOrganizer
{
    public partial class MainForm : Form
    {
        EventManager eventManager;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            btnAdd.Enabled = false;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            cbCountryList.DataSource = Enum.GetValues(typeof(Countries));
        }

        public void checkEventEconomy()
        {
            lblNumberOfParticipants.Text = "" + eventManager.numberOfParticipants();
            lblTotalCost.Text = eventManager.CalcTotalCost() + " SEK";
            lblTotalFees.Text = eventManager.CalcTotalFees() + " SEK";
            lblSurplus.Text = eventManager.CalcTotalFees() - eventManager.CalcTotalCost() + " SEK";
        }

        /*
         * This method is called when Create Event button is clicked. 
         * First the user inputs are checked and then the event is created
         */
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            if (tbEventTitle.Text.Equals("") || tbCostPerParticipant.Text.Equals("") || tbFeePerParticipant.Text.Equals(""))
            {
                MessageBox.Show("Fyll all the inputs", "Missing inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!tbEventTitle.Text.Equals("") && !tbCostPerParticipant.Text.Equals("") && !tbFeePerParticipant.Text.Equals(""))
            {
                string eventTitle = tbEventTitle.Text;
                int costPerParticipant = int.Parse(tbCostPerParticipant.Text);
                int feePerParticipant = int.Parse(tbFeePerParticipant.Text);

                eventManager = new EventManager();
                eventManager.CostPerPerson = costPerParticipant;
                eventManager.FeePerPerson = feePerParticipant;
                eventManager.Title = eventTitle;
                this.Text = eventTitle;

                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnCreateEvent.Enabled = false;

                MessageBox.Show("Evenet '" + eventTitle + "' was created");
                checkEventEconomy();
            }


        }

        /*
         * This method is called when the Add button is clicked. 
         * First the user inputs are checked and then a new Participant is created based on the user inputs.
         * Lastly the GUI is updated
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Equals("") || tbLastName.Text.Equals("") || tbStreet.Text.Equals("") || tbCity.Text.Equals("") || tbZipCode.Text.Equals(""))
            {
                MessageBox.Show("Fyll all the inputs", "Missing inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!tbFirstName.Text.Equals("") && !tbLastName.Text.Equals("") && !tbStreet.Text.Equals("") && !tbCity.Text.Equals("") && !tbZipCode.Text.Equals(""))
            {
                string country = cbCountryList.SelectedItem.ToString();

                Address address = new Address(tbStreet.Text, tbCity.Text, tbZipCode.Text, (Countries)Enum.Parse(typeof(Countries), country));

                Participant participant = new Participant(tbFirstName.Text, tbLastName.Text, address);

                eventManager.Participants.AddParticipant(participant);

                MessageBox.Show("The participant '" + tbFirstName.Text + ", " + tbLastName.Text + "' was added!");

                UpdateGUI(true);
                checkEventEconomy();
            }
        }

        /*
         * This method is called to update the GUI (mainly the listbox) 
         * First clear alla the items in the listbox and then update with the new participant data
         */
        private void UpdateGUI(bool clearAll)
        {
            if (clearAll)
            {
                clearAllTextBoxes();
            }

            List<Participant> participants = eventManager.Participants.GetAllParticipants();
            listBoxParticipants.Items.Clear();

            for (int i = 0; i < participants.Count; i++)
            {
                Participant user = participants[i];
                listBoxParticipants.Items.Add(user.FullName + "\t\t" + user.Address.Street + "\t"
                    + user.Address.ZipCode + "\t" + user.Address.City);
            }
        }

        public void clearAllTextBoxes()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbStreet.Clear();
            tbCity.Clear();
            tbZipCode.Clear();
        }

        /*
         * This method is called when a Participant needs to be removed from the participants list. 
         * Lastly the GUI is updated after the participant is removed
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            eventManager.Participants.DeleteParticipantAt(listBoxParticipants.SelectedIndex);
            MessageBox.Show("This participant was removed");
            UpdateGUI(false);
            checkEventEconomy();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }
      
    }
}
