using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicksAutoClicker
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {

            InitializeComponent();

        }

        private bool drag = false; 
        private Point startPoint = new Point(0, 0); 

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.FindForm().Location = p3;
            }
        }


        private void title_MouseDown(object sender, MouseEventArgs e)
        {

            this.startPoint = e.Location;
            this.drag = true;
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FindForm().WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }
    }
}
