using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PictureViewer
{
    /// <summary>
    /// Represents the main PictureViewer window.
    /// </summary>
    public partial class PictureViewerWindow : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureViewerWindow"/> class.
        /// </summary>
        public PictureViewerWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box,
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears
            // the check box, change it to "Normal".
            if (stretchCheckBox.Checked)
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog.FileName);
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog.ShowDialog() == DialogResult.OK)
                pictureBox.BackColor = colorDialog.Color;
        }
    }
}