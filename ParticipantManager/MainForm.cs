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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

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
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using(FileStream stream = File.Create("participants.bin"))
                {
                    formatter.Serialize(stream, _participants);
                }
                MessageBox.Show("Participants saved (binary)");
            }catch(Exception ex)
            {
                MessageBox.Show("Error saving binary file: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.OpenRead("participants.bin"))
                {
                    if (stream.Length > 0)
                    {
                        _participants = (List<Participant>)formatter.Deserialize(stream);
                        DisplayParticipants();
                    }
                    else
                    {
                        MessageBox.Show("Binary file is empty");
                        _participants.Clear();
                        DisplayParticipants();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Binary file not found", "Load error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _participants.Clear();
                DisplayParticipants();
            }catch(Exception ex)
            {
                MessageBox.Show("Error reading binary file: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _participants.Clear(); // Clear list on error
                DisplayParticipants();
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
                using (FileStream stream = File.Create("participants.xml"))
                {
                    serializer.Serialize(stream, _participants);
                }
                MessageBox.Show("Participants saved (XML)", "", MessageBoxButtons.OK);
            }
            catch(Exception)
            {
                MessageBox.Show("Error saving XML file", "", MessageBoxButtons.OK);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
                using (FileStream stream = File.OpenRead("participants.xml"))
                {
                    if(stream.Length > 0)
                    {
                        _participants = (List<Participant>)serializer.Deserialize(stream);
                        DisplayParticipants();
                    }
                    else
                    {
                        MessageBox.Show("XML file is empty");
                        _participants.Clear();
                        DisplayParticipants();
                    }
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("XML file not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _participants.Clear();
                DisplayParticipants();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _participants.Clear();
                DisplayParticipants();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Create and configure the SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv|Text File (*.txt)|*.txt"; // Allow saving as .csv or .txt
            saveFileDialog.Title = "Export Participants Data";
            saveFileDialog.FileName = "participants"; // Default file name

            // 2. Show the dialog and check if the user clicked OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 3. Get the chosen filename
                string filePath = saveFileDialog.FileName;

                try
                {
                    // 4. Use StreamWriter within a 'using' block to write the file
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        // Write Header Row
                        sw.WriteLine("LastName,FirstName,BirthDate");

                        // Write Data Rows for each participant
                        foreach (var participant in _participants)
                        {
                            // Format as CSV, enclosing in quotes and escaping internal quotes
                            sw.WriteLine("\"{0}\",\"{1}\",\"{2}\"",
                               participant.LastName.Replace("\"", "\"\""), // Handle quotes in data
                               participant.FirstName.Replace("\"", "\"\""),
                               participant.BirthDate.ToShortDateString());
                        }
                    } // 'using' ensures sw.Close() / sw.Dispose() is called automatically

                    MessageBox.Show("Data exported successfully to " + filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting file: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // else: User clicked Cancel, so do nothing.
        }
    }
    
}
