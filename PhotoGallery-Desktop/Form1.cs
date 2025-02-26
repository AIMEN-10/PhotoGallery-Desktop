using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PhotoGallery_Desktop
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {




        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize the logic object
                Logic logic = new Logic();

                // Fetch the data table asynchronously
                object dataTable = await logic.Group_by_date();

                // Check if the DataTable is null
                if (dataTable == null)
                {
                    MessageBox.Show("No data received from the API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (dataTable is Dictionary<string, object> dictionary)
                {
                    // Display all keys for debugging purposes
                    string keys = string.Join(", ", dictionary.Keys); // Join all keys into a comma-separated string
                    MessageBox.Show($"Available keys: {keys}", "Keys Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Display all key-value pairs (optional for debugging)
                    foreach (var kvp in dictionary)
                    {
                        MessageBox.Show($"Key: {kvp.Key}, Value: {kvp.Value}");
                    }
                }
                else
                {
                    MessageBox.Show("Unexpected data format received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Check if there are any rows in the DataTable
                //if (dataTable.Rows.Count == 0)
                //{
                //    MessageBox.Show("No rows available in the data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                //// Iterate through rows and load images
                //for (int i = 0; i < dataTable.Rows.Count; i++)
                //{
                //    // Check if "path" column exists and is not null
                //    if (!dataTable.Columns.Contains("path") || dataTable.Rows[i]["path"] == DBNull.Value)
                //    {
                //        MessageBox.Show($"The 'path' column is missing or contains null for row {i}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        continue;
                //    }

                //    string path = dataTable.Rows[i]["path"].ToString();

                //    // Update the label
                //    label2.Text = path;

                //    // Check if the file exists before trying to load the image
                //    if (System.IO.File.Exists(path))
                //    {
                //        pictureBox2.Image = Image.FromFile(path);
                //    }
                //    else
                //    {
                //        MessageBox.Show($"File not found: {path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
