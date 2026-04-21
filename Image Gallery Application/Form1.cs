using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Gallery_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    string fileName = Path.GetFileName(filePath);

                    // Create Image object (your class)
                    ImageItem img = new ImageItem(fileName, filePath);

                    // Add to list (requirement)
                    imageList.Add(img);

                    // Display in preview
                    pictureBox1.Image = Image.FromFile(filePath);

                    // Add to grid gallery
                    AddImageToGallery(img);
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading image: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

