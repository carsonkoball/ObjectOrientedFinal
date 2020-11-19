using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Environment> EnvironmentList = new List<Environment>();
        List<String> DisplayList = new List<String>();

        private int EnvironmentCounter = 0;
        private bool AquariumSelected = false;
        public Form1()
        {
            InitializeComponent();
            AquariumButton.Checked = true;
            AquariumPH.DecimalPlaces = 2;
            AquariumPH.ThousandsSeparator = true;
            AquariumPH.Increment = 0.1M;
            AquariumPH.Value = 7.0M;
            AquariumPH.Maximum = 14;
            AquariumPH.Minimum = 0;
            InhabitantCounter.Minimum = 0;
            InhabitantCounter.DecimalPlaces = 0;
            EnvironmentListBox.DisplayMember = "Test";
            EnvironmentListBox.ValueMember = "TE";
        }

        public void toggleNumericUpDown1()
        {
            WaterPHLabel.Visible = AquariumButton.Checked;
            AquariumPH.Visible = AquariumButton.Checked;
            WaterPHTextBox.Visible = AquariumSelected;
            WPHLabel.Visible = AquariumSelected;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            AquariumButton.AutoCheck = true;
            toggleNumericUpDown1();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AquariumButton.Checked == true)
            {
                int environmentid = EnvironmentCounter;
                string environmenttype = InhabitantType.Text;
                double aquariumph = Convert.ToDouble(AquariumPH.Value);
                EnvironmentList.Add(new Aquarium(environmentid, environmenttype, aquariumph));
                DisplayList.Add(environmenttype + " Aquarium");

                EnvironmentListBox.Items.Add(DisplayList[DisplayList.Count - 1]);

                EnvironmentCounter++;
            } else if (CageButton.Checked == true)
            {
                int environmentid = EnvironmentCounter;
                string environmenttype = InhabitantType.Text;
                EnvironmentList.Add(new Cage(environmentid, environmenttype));
                DisplayList.Add(environmenttype + " Cage");
                EnvironmentListBox.Items.Add(DisplayList[DisplayList.Count - 1]);
                EnvironmentCounter++;

            } else if (TerrariumButton.Checked == true)
            {
                int environmentid = EnvironmentCounter;
                string environmenttype = InhabitantType.Text;
                EnvironmentList.Add(new Terrarium(environmentid, environmenttype));
                DisplayList.Add(environmenttype + " Terrarium");
                EnvironmentListBox.Items.Add(DisplayList[DisplayList.Count - 1]);
                EnvironmentCounter++;
            }
            AquariumPH.Value = 7;
            InhabitantType.Text = String.Empty;
        }

        private void EnvironmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnvironmentListBox.SelectedItem != null)
            {
                string environment = EnvironmentListBox.SelectedItem.ToString();
                int index = EnvironmentListBox.SelectedIndex;
                Environment _environment = EnvironmentList[index];
                string type = _environment.GetType().ToString();
                if (type.Equals("WindowsFormsApp1.Aquarium"))
                {
                    AquariumSelected = true;
                }
                else
                {
                    AquariumSelected = false;
                }
                toggleNumericUpDown1();
                IDTextBox.Text = _environment.GetID().ToString();
                CleanTimeTextBox.Text = _environment.GetLastTimeCleaned().ToString();
                FeedTimeTextBox.Text = _environment.GetLastTimeFed().ToString();
                InhabitantCountTextBox.Text = _environment.GetNumberOfInhabitants().ToString();
                InhabitantTypeTextBox.Text = _environment.GetInhabitant().ToString();
                WaterPHTextBox.Text = _environment.GetWaterpH().ToString("##,##.00");
            }
        }

        private void FeedButton_Click(object sender, EventArgs e)
        {
            if (EnvironmentListBox.SelectedItem != null)
            {
                int index = EnvironmentListBox.SelectedIndex;
                Environment _environment = EnvironmentList[index];
                _environment.Feed();
                CleanTimeTextBox.Text = _environment.GetLastTimeFed().ToString();
            }       
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            if (EnvironmentListBox.SelectedItem != null)
            {
                int index = EnvironmentListBox.SelectedIndex;
                Environment _environment = EnvironmentList[index];
                _environment.Clean();
                FeedTimeTextBox.Text = _environment.GetLastTimeCleaned().ToString();
            }   
        }

        private void AddInhabitantButton_Click(object sender, EventArgs e)
        {
            if (EnvironmentListBox.SelectedItem != null)
            {
                int index = EnvironmentListBox.SelectedIndex;
                Environment _environment = EnvironmentList[index];
                int inhabitantcounter = Convert.ToInt32(InhabitantCounter.Value);
                _environment.AddInhabitants(inhabitantcounter);
                InhabitantCountTextBox.Text = _environment.GetNumberOfInhabitants().ToString();
            }

            InhabitantCounter.Value = 0;
        }

        private void RemoveInhabitantButton_Click(object sender, EventArgs e)
        {
            if (EnvironmentListBox.SelectedItem != null)
            {
                int index = EnvironmentListBox.SelectedIndex;
                Environment _environment = EnvironmentList[index];
                int inhabitantcounter = Convert.ToInt32(InhabitantCounter.Value);
                int currentinhabitantcount = _environment.GetNumberOfInhabitants();
                if (currentinhabitantcount < inhabitantcounter)
                {
                    _environment.RemoveInhabitants(currentinhabitantcount);
                }
                else
                {
                    _environment.RemoveInhabitants(inhabitantcounter);
                }
                InhabitantCountTextBox.Text = _environment.GetNumberOfInhabitants().ToString();
            }

            InhabitantCounter.Value = 0;
        }

        private void RemoveEnvironmentButton_Click(object sender, EventArgs e)
        {
            if (EnvironmentListBox.SelectedItem != null)
            {
                int index = EnvironmentListBox.SelectedIndex;
                Environment _environment = EnvironmentList[index];
                EnvironmentListBox.ClearSelected();
                EnvironmentListBox.Items.RemoveAt(index);
                DisplayList.RemoveAt(index);
                IDTextBox.Text = String.Empty;
                CleanTimeTextBox.Text = String.Empty;
                FeedTimeTextBox.Text = String.Empty;
                InhabitantCountTextBox.Text = String.Empty;
                InhabitantTypeTextBox.Text = String.Empty;
                WaterPHTextBox.Text = String.Empty;
            }
        }
    }
}
