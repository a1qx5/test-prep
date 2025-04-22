using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParticipantManager.Entities;

namespace ParticipantManager
{
    public partial class MainForm: Form
    {
        private List<Participant> _participants = new List<Participant>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void serializaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text.Trim()))
            {
                errorProvider.SetError(tbLastName, "Last name cannot be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbLastName, string.Empty);
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text.Trim()))
            {
                errorProvider.SetError(tbFirstName, "First name cannot be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbFirstName, string.Empty);
            }
        }

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if(dtpBirthDate.Value.Date >= DateTime.Today)
            {
                errorProvider.SetError(dtpBirthDate, "Birthday cannot be today or in the future!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpBirthDate, string.Empty);
            }
        }

        private void DisplayParticipants()
        {
            lvParticipants.Items.Clear();
            _participants.Sort();

            if (_participants == null) return;

            foreach(var participant in _participants)
            {
                ListViewItem item = new ListViewItem(participant.LastName);
                item.SubItems.Add(participant.FirstName);
                item.SubItems.Add(participant.BirthDate.ToShortDateString());
                item.Tag = participant;
                lvParticipants.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the validation errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string lastName = tbLastName.Text.Trim();
                string firstName = tbFirstName.Text.Trim();
                DateTime birthDate = dtpBirthDate.Value;

                Participant participant = new Participant(lastName, firstName, birthDate);
                _participants.Add(participant);
                DisplayParticipants();

                tbLastName.Clear();
                tbFirstName.Clear();
                dtpBirthDate.Value = DateTime.Now;
                tbLastName.Focus();
            }
            catch(ArgumentNullException anex)
            {
                MessageBox.Show("Error adding participant: " + anex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An unexpected error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
