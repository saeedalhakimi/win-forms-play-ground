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
    public partial class frmImageBox : Form
    {
        public frmImageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random random = new Random();
            new[] { picBox1, picBox2 }.ToList().ForEach(picBox => picBox.Image = (Image)Properties.
            Resources.ResourceManager.GetObject("dice_" + random.Next(1, 7)));


            //Random random = new Random();
            //foreach (PictureBox picBox in new[] { picBox1, picBox2 })
            //{
            //    int randomNumber = random.Next(1, 7);
            //    picBox.Image = (Image)Properties.Resources.
            //        ResourceManager.GetObject("dice_" + randomNumber);
            //}


            //Random random = new Random();
            //int randomNumber1 = random.Next(1, 7);
            //int randomNumber2 = random.Next(1, 7);
            //Image[] diceImages = { Resources.dice_1, Resources.dice_2, 
            //    Resources.dice_3, Resources.dice_4, Resources.dice_5, Resources.dice_6 };
            //for (int i = 0; i < diceImages.Length; i++)
            //{
            //    if (randomNumber1 == i + 1)
            //    {
            //        picBox1.Image = diceImages[i];
            //    }
            //    if (randomNumber2 == i + 1)
            //    {
            //        picBox2.Image = diceImages[i];
            //    }
            //}


            //Random random = new Random();
            //int randomNumber = random.Next(1, 7);
            //Image[] diceImages = { Resources.dice_1, Resources.dice_2, Resources.dice_3, Resources.dice_4, Resources.dice_5, Resources.dice_6 };
            //for (int i = 0; i < diceImages.Length; i++)
            //{
            //    if (randomNumber == i + 1)
            //    {
            //        picBox1.Image = diceImages[i];
            //        break;
            //    }
            //}
            //Random random = new Random();
            //int randomNumber = random.Next(1, 7);
            //switch (randomNumber)
            //{
            //    case 1:
            //        picBox.Image = Resources.dice_1;
            //        break;
            //    case 2:
            //        picBox.Image = Resources.dice_2;
            //        break;
            //    case 3:
            //        picBox.Image = Resources.dice_3;
            //        break;  
            //    case 4:
            //        picBox.Image = Resources.dice_4;
            //        break;
            //    case 5:
            //        picBox.Image = Resources.dice_5;
            //        break;
            //    case 6:
            //        picBox.Image = Resources.dice_6;
            //        break;
            //}
            //string imageName = "dice_" + randomNumber + ".png";
            //picBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
        }
    }
}
