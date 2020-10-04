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
        bool AddingClicker = true;


        const int thinWidth = 290;
        const int wideWidth = 800;

        float currentWidth;
        float targetWidth;
        List<Condition> Conditions = new List<Condition>();
        public MainForm()
        {
            InitializeComponent();
            comboAction.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            splitContainer1.SplitterWidth =1;
            splitContainer5.SplitterWidth = 8;

            currentWidth = Width;
            targetWidth = Width;

            ToggleSideBar();

            if (ClickerManager.Clickers.Count <= 0)
            {
            }

        }
        public void UpdateConditionTitles()
        {
            if (Conditions.Count <= 0) return;

            Conditions[0].lblTitle.Text = "When";

            for (int i = 1; i < Conditions.Count; i++)
            {
                Conditions[i].lblTitle.Text = "And";
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

        private void button5_Click(object sender, EventArgs e)
        {
            Condition con = new Condition(Conditions);
            con.Dock = DockStyle.Top;
            con.Height = 36;
            pnlConditions.Controls.Add(con);
            con.BringToFront();

            UpdateConditionTitles();

        }
        void ToggleSideBar(bool instant = false, bool? enable = null)
        {
            if (enable != null)
            {
                AddingClicker = (bool)enable;
            } else
            {            AddingClicker = !AddingClicker;

            }

            if (AddingClicker)
            {
                button10.Text = "ADD NEW";
                button10.BackColor = Color.MediumSeaGreen;


                //pnlSideBar = true;
                targetWidth = thinWidth;
            }
            else
            {
                button10.Text = "CANCEL";
                button10.BackColor = Color.IndianRed;

                targetWidth = wideWidth;
                //pnlSideBar = false;

            }

            if (instant)
            {
                Width = (int)targetWidth;
                currentWidth = Width;
            } else
            {
                ActiveAnimations.Add(ActiveAnimation.WidthIncrease);
                animation.Start();
            }

        }
        enum ActiveAnimation
        {
            WidthIncrease
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
                        case ActiveAnimation.WidthIncrease:
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
            ToggleSideBar();

        }
    }
}
