using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Faculty_GUI
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Faculty> facultyDictionary = new Dictionary<string, Faculty>();

        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }
        private void InitializeGui()
        {
            lstFaculty.Items.Clear();
            lstFaculty.Items.Add("ListFaculty");

            // Populate the dictionary and list box with faculty data
            List<Faculty> facultyList = Faculty.GetFaculties();
            foreach (var faculty in facultyList)
            {
                string key = faculty.GenerateKey(); // Generate the key (last name)
                facultyDictionary[key] = faculty;  // Add to dictionary
                lstFaculty.Items.Add(key);         // Add key (last name) to ListBox
            }

            lstFaculty.SelectedIndex = 0;

            // Populate feedback ComboBox with numbers 1 to 5
            cmbFeedback.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                cmbFeedback.Items.Add(i.ToString());
            }
        }
        private void UpdateGui(string key)
        {
            if (!facultyDictionary.ContainsKey(key)) return;

            // Retrieve the faculty object
            Faculty faculty = facultyDictionary[key];

            // Update the labels with faculty details
            lblName.Text = faculty.Name;
            lblLife.Text = faculty.Life;
            lblStart.Text = faculty.Start;
            lblEnd.Text = faculty.End;
            lblDepartment.Text = faculty.Department;

            // Reset feedback score and salary
            cmbFeedback.SelectedIndex = -1; // Clear the selected feedback score
            lblNewSalary.Text = string.Empty; // Clear the salary label

            // Update the faculty image
            string imagePath = Path.Combine(Application.StartupPath, "Images", $"{key}.png");
            string defaultImagePath = Path.Combine(Application.StartupPath, "Images", "default.png");

            if (File.Exists(imagePath))
            {
                picFaculty.Image = Image.FromFile(imagePath);
            }
            else if (File.Exists(defaultImagePath))
            {
                picFaculty.Image = Image.FromFile(defaultImagePath); // Load default image if specific image is missing
            }
            else
            {
                picFaculty.Image = null; // Clear the PictureBox if no default image is available
                MessageBox.Show("Image Not Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstFaculty_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstFaculty.SelectedItem != null)
            {
                string selectedItem = lstFaculty.SelectedItem.ToString();

                if (selectedItem == "ListFaculty")
                {
                    lblName.Text = string.Empty;
                    lblLife.Text = string.Empty;
                    lblStart.Text = string.Empty;
                    lblEnd.Text = string.Empty;
                    lblDepartment.Text = string.Empty;
                    picFaculty.Image = null;
                    lblNewSalary.Text = string.Empty;
                    cmbFeedback.SelectedIndex = -1;
                    return;
                }

                UpdateGui(selectedItem);
            }
        }
        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            if (lstFaculty.SelectedItem != null)
            {
                string key = lstFaculty.SelectedItem.ToString();
                if (facultyDictionary.ContainsKey(key))
                {
                    Faculty faculty = facultyDictionary[key];

                    if (decimal.TryParse(cmbFeedback.Text, out decimal feedbackScore))
                    {
                        // Validate feedback score range
                        if (feedbackScore < 1 || feedbackScore > 5)
                        {
                            MessageBox.Show("Feedback score must be between 1 and 5.", "Invalid Feedback Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Update the feedback score and calculate salary
                        faculty.FeedbackScore = feedbackScore;
                        decimal salary = faculty.CalculateSalary();
                        lblNewSalary.Text = $"${salary:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid feedback score. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}

