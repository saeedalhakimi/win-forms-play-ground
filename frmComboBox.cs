using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplayGround.Properties;

namespace WindowsFormsApplayGround
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox1.Text);
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = 0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {





            // Get the selected index of comboBox4
            int selectedIndex = comboBox4.SelectedIndex;

            // Use a switch statement to handle each case
            switch (selectedIndex)
            {
                // If the selected index is 0, set the image to the boy image and the label to "BOY"
                case 0:
                    pictureBox1.Image = Resources.Boy;
                    label4.Text = "BOY";
                    break;

                // If the selected index is 1, set the image to the girl image and the label to "GIRL"
                case 1:
                    pictureBox1.Image = Resources.Girl;
                    label4.Text = "GIRL";
                    break;

                // If the selected index is 2, set the image to the book image and the label to "BOOK"
                case 2:
                    pictureBox1.Image = Resources.Book;
                    label4.Text = "BOOK";
                    break;

                // If the selected index is 3, set the image to the pen image and the label to "PEN"
                case 3:
                    pictureBox1.Image = Resources.Pen;
                    label4.Text = "PEN";
                    break;

                // If the selected index is not 0, 1, 2, or 3, throw an exception
                default:
                    throw new ArgumentOutOfRangeException("Invalid index selected");
            }



            //switch (comboBox4.SelectedIndex)
            //{
            //    case 0:
            //        pictureBox1.Image = Resources.Boy;
            //        label4.Text = "BOY";
            //        break;
            //    case 1:
            //        pictureBox1.Image = Resources.Girl;
            //        label4.Text = "GIRL";
            //        break;
            //    case 2:
            //        pictureBox1.Image = Resources.Book;
            //        label4.Text = "BOOK";
            //        break;
            //    case 3:
            //        pictureBox1.Image = Resources.Pen;
            //        label4.Text = "PEN";
            //        break;
            //    default:
            //        break;
            //}

            //if (comboBox4.SelectedIndex == 0)
            //{
            //    pictureBox1.Image = Resources.Boy;
            //    label4.Text = "BOY";
            //}

            //if (comboBox4.SelectedIndex == 1)
            //{
            //    pictureBox1.Image = Resources.Girl;
            //    label4.Text = "GIRL";
            //}

            //if (comboBox4.SelectedIndex == 2)
            //{
            //    pictureBox1.Image = Resources.Book;
            //    label4.Text = "BOOK";
            //}

            //if (comboBox4.SelectedIndex == 3)
            //{
            //    pictureBox1.Image = Resources.Pen;
            //    label4.Text = "PEN";
            //}
        }
    }
}
