using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicksAutoClicker
{
    public partial class MainForm : Form
    {


        const int thinWidth = 290;
        const int wideWidth = 800;

        

        public Control SideBarControl;

        public MainForm()
        {
            InitializeComponent();
            AnimationManager.setTimer(animation);   
            splitContainer1.SplitterWidth =1;

            currentWidth = Width;
            targetWidth = Width;

            ToggleSideBar(true, false);

            if (ClickerManager.Clickers.Count <= 0)
            {
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        public bool SideBarVisible = false;
        public float currentWidth;
        public float targetWidth;
        void ToggleSideBar(bool instant = false, bool? visible = null)
        {

            if (visible != null)
            {
                SideBarVisible = (bool)visible;
            } else
            {
                SideBarVisible = !SideBarVisible;
            }

            if (SideBarVisible)
            {
                targetWidth = wideWidth;
            }
            else
            {
                targetWidth = thinWidth;
            }
            if (instant)
            {
                Width = (int)targetWidth;
                currentWidth = Width;
            } else 
            {
                AnimationManager.ActiveAnimations.Add(new Animations.SideBarToggle(this));
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (pnlSideBar.GetType().Equals(typeof(AddClicker)))
            {
                button10.Text = "ADD NEW";
                button10.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                button10.Text = "CANCEL";
                button10.BackColor = Color.IndianRed;
            }
            AddClicker clickerControl = new AddClicker();

            SideBarControl = clickerControl;
            pnlSideBar.Controls.Clear();
            pnlSideBar.Controls.Add(clickerControl);
            ToggleSideBar();

        }

    }
}
