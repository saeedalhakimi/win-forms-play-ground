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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fr = new Form1();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new Form2();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Koko";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form fr= new lblForm();
            fr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form fr = new msgBoxForm();
            fr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form fr = new pizzaForm();
            fr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form fr = new regitrationForm();
            fr.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form fr = new loginForm();
            fr.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Form fr =new frmImageBox();
            fr.ShowDialog();    
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form fr = new frmPaint();
            fr.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form fr = new frmMaskedText();
            fr.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form fr=new frmComboBox();  
            fr.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form fr = new   frmLinkLabel();
            fr.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form fr=new frmCheckedListitems();
            fr.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form fr=new frmDateTimePicker();
            fr.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form fr = new frmMonthCalender();
            fr.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form fr = new frmtimer();
            fr.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form fr = new frmNotifyIcon();
            fr.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form fr=new frmTreeView();  
            fr.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form fr=new frmProgressBar();   
            fr.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form fr=new frmListView();
            fr.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form fr =new frmErrorProvider();    
            fr.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form fr=new frmTrackBar();
            fr.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form fr=new frmNumericUpDown();
            fr.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form fr=new frmTabeControl();
            fr.ShowDialog();
        }
    }
}
