using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplayGround
{
    public partial class frmMaskedText : Form
    {
        public frmMaskedText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            // Declare arrays of text boxes and labels
            var textBoxes = new[] { maskedTextBox1, maskedTextBox2, maskedTextBox3,
                maskedTextBox4, maskedTextBox5, maskedTextBox6, maskedTextBox7 };
            var labels = new[] { label1, label2, label3, label4, label5, label6, label7 };

            // Loop over the text boxes and labels using the foreach loop
            foreach (var (textBox, label) in textBoxes.Zip(labels, (t, l) => (t, l)))
            {
                // Set the text of the label to "OK" if the corresponding text box has a valid mask, and "Error" otherwise
                label.Text = textBox.MaskFull ? "OK" : "Error";
            }




            //var textBoxes = new[] { maskedTextBox1, maskedTextBox2, maskedTextBox3,
            //    maskedTextBox4, maskedTextBox5, maskedTextBox6, maskedTextBox7 };
            //var labels = new[] { label1, label2, label3, label4, label5, label6, label7 };

            //for (int i = 0; i < textBoxes.Length; i++)
            //{
            //    labels[i].Text = textBoxes[i].MaskFull ? "OK" : "Error";
            //}





            //if (maskedTextBox1.MaskFull) 
            //{
            //    label1.Text = "OK";
            //}
            //else
            //{
            //    label1.Text = "Error";
            //}

            //if (maskedTextBox2.MaskFull)
            //{
            //    label2.Text = "OK";
            //}
            //else
            //{
            //    label2.Text = "Error";
            //}

            //if (maskedTextBox3.MaskFull)
            //{
            //    label3.Text = "OK";
            //}
            //else
            //{
            //    label3.Text = "Error";
            //}

            //if (maskedTextBox4.MaskFull)
            //{
            //    label4.Text = "OK";
            //}
            //else
            //{
            //    label4.Text = "Error";
            //}

            //if (maskedTextBox5.MaskFull)
            //{
            //    label5.Text = "OK";
            //}
            //else
            //{
            //    label5.Text = "Error";
            //}

            //if (maskedTextBox6.MaskFull)
            //{
            //    label6.Text = "OK";
            //}
            //else
            //{
            //    label6.Text = "Error";
            //}

            //if (maskedTextBox7.MaskFull)
            //{
            //    label7.Text = "OK";
            //}
            //else
            //{
            //    label7.Text = "Error";
            //}


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
