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
    public partial class pizzaForm : Form
    {
        public pizzaForm()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pizzaForm_Load(object sender, EventArgs e)
        {
            rbSmallSize.Text = "Small" + " ($" + rbSmallSize.Tag.ToString()+").";
            rbMiddSize.Text = "medium" + " ($" + rbMiddSize.Tag.ToString() + ").";
            rbMiddSize.Text = "Medium" + " ($" + rbMiddSize.Tag.ToString() + ").";
            rbLargeSize.Text = "Large" + " ($" + rbLargeSize.Tag.ToString() +").";


            gbToppings.Text = "Toppings: "+"($"+gbToppings.Tag.ToString()+" per each)";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
