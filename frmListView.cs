using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplayGround
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            listView1.BeginUpdate();

            var item = new ListViewItem(txtID.Text.Trim());
            item.SubItems.Add(txtName.Text.Trim());

            if (rbMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            listView1.Items.Add(item);

            listView1.EndUpdate();

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                
                if(i%2==0)
                    item.ImageIndex = 0;
                else 
                    item.ImageIndex = 1;

                item.SubItems.Add("Person"+i);
                listView1.Items.Add(item);
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLargIcons_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon ;
        }

        private void rdSmallIcons_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rdListView_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
