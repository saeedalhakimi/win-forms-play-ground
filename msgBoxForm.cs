using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApplayGround
{
    public partial class msgBoxForm : Form
    {
        public msgBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, this is the message box body!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, this is the message box body!", "Hi, this is the title!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi, this is the message box body!", 
                "Hi, this is the title!", 
                MessageBoxButtons.OKCancel
                ) == DialogResult.OK)
            {
                MessageBox.Show("you clicked ok");
            }
            else
            {
                MessageBox.Show("you clicked cancel");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi, this is the message box body!",
                                "Hi, this is the title!", 
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information
                ) == DialogResult.OK)
            {
                MessageBox.Show("you clicked ok");
            }
            else
            {
                MessageBox.Show("you clicked cancel");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi, this is the message box body!",
                    "Hi, this is the title!", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2
                ) == DialogResult.OK)
            {
                MessageBox.Show("you clicked ok");
            }
            else
            {
                MessageBox.Show("you clicked cancel");
            }
        }
    }
}
