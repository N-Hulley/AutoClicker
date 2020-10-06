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

        float currentWidth;
        float targetWidth;

        public Control SideBarControl;

        public MainForm()
        {
            InitializeComponent();
            
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

        bool SideBarVisible = false;
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
                ActiveAnimations.Add(ActiveAnimation.SideBarToggle);
                animation.Start();
            }
        }
        enum ActiveAnimation
        {
            SideBarToggle
        }
        

        IList<ActiveAnimation> ActiveAnimations = new List<ActiveAnimation>();
        private void animation_Tick(object sender, EventArgs e)
        {
            if (ActiveAnimations.Count <= 0)
            {
                animation.Stop();
            }
            else
            {
                for (int i = ActiveAnimations.Count-1; i >= 0; i--)
                {
                    switch (ActiveAnimations[i])
                    {
                        case ActiveAnimation.SideBarToggle:
                            if (Math.Round(currentWidth) != Math.Round(targetWidth))
                            {
                                currentWidth = Lerp(currentWidth, targetWidth, (1f / (float)animation.Interval) * 3);
                                Width = (int)Math.Round(currentWidth);

                            }else
                            {
                                ActiveAnimations.RemoveAt(i);
                            }
                            break;
                    }

                } 
            }

        }
        public static float Lerp(float v1, float v2, float t)
        {
            return v1 + ((v2 - v1) * t);
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
