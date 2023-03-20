﻿using System;
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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker7.Value.ToLongDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker7.Value.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker7.Value.ToLongTimeString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker7.Value.ToShortTimeString());
        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = dateTimePicker7.Text + Environment.NewLine;
            label7.Text += dateTimePicker7.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label7.Text += dateTimePicker7.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label7.Text += dateTimePicker7.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            label7.Text += dateTimePicker7.Value.ToString("dd/MM/yy") + Environment.NewLine;
            label7.Text += dateTimePicker7.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;
            
        }
    }
}
