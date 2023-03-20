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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

       

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;    
            button2.Enabled = false;    
            button3.Enabled = false;    
            button4.Enabled = false;    
            button5.Enabled = false;    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;    
            button2.Enabled = true;    
            button3.Enabled = true;    
            button4.Enabled = true;    
            button5.Enabled = true; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }
    }
}
