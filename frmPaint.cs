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
    public partial class frmPaint : Form
    {
        public frmPaint()
        {
            InitializeComponent();
        }

        private void frmPaint_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.FromArgb(255,0, 0, 0);
            
            Pen Pen = new Pen(black);
            Pen.Width = 5;

            //Pen.DashStyle =
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen,40, 40, 500, 40);
            e.Graphics.DrawLine(Pen,40, 40, 40, 500);

            e.Graphics.DrawLine(Pen,100, 100, 100, 200);
            e.Graphics.DrawRectangle(Pen, 200, 80, 100, 120);
            e.Graphics.DrawEllipse(Pen, 300, 100, 200, 210);


            
        }

        private void frmPaint_Load(object sender, EventArgs e)
        {

        }
    }
}
