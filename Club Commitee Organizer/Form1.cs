using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_Commitee_Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
            {
                "Activities",
                "Community Services",
                "Executive",
                "Membership",
                "Programming Team",
                "Scholarship",
                "Sports",
                "Travel",
                "Volunteer Tutoring"
            });

            List<string> generalMembers = new List<string>
        {
            "Adams, Ben",
            "Baker, Sam",
            "Chong, Anne",
            "Davis, Sandra",
            "Easterlin, John",
            "Fernandez, Jose",
            "Fox, Barbara",
            "Gomez, Ignacio"
        };
            listBoxAllMembers.Items.AddRange(generalMembers.ToArray());

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            foreach(var selectedMember in listBoxAllMembers.SelectedItems)
            {
                if(listBoxAllMembers.Items.Contains(selectedMember))
                {
                    listBoxCurrentMembers.Items.Add(selectedMember);
                }
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            var selectedMembers = new List<object>(listBoxCurrentMembers.SelectedItems.Cast<object>());

            foreach (var selectedMember in selectedMembers)
                {
                listBoxCurrentMembers.Items.Remove(selectedMember);
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a committee first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
