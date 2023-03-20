using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplayGround
{
    public partial class frmLinkLabel : Form
    {
        public frmLinkLabel()
        {
            InitializeComponent();
        }

       

        private void LinkLabel_LinkClicked(object sender, EventArgs e)
        {
            // Get the URL to open
            string url = "www.google.com";

            // Get the LinkLabel control that was clicked
            LinkLabel linkLabel = (LinkLabel)sender;

            // Set the LinkVisited property to true
            linkLabel.LinkVisited = true;

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }
    }
    
}
