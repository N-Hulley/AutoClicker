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
        //public MainForm()
        //{
        //    InitializeComponent();
        //}
        List<Condition> Conditions = new List<Condition>();
        public MainForm()
        {
            InitializeComponent();
            comboAction.SelectedIndex = 0;
            comboActionCondition.SelectedIndex = 0;
            splitContainer1.SplitterWidth =1;
            splitContainer2.SplitterWidth = 8;
            splitContainer3.SplitterWidth = 8;
            splitContainer4.SplitterWidth = 8;
            splitContainer5.SplitterWidth = 8;


        }

        private const int SnapDist = 100;

        private void button5_Click_1(object sender, EventArgs e)
        {

            Condition con = new Condition(Conditions);
            con.Dock = DockStyle.Top;
            pnlConditions.Controls.Add(con);
            con.BringToFront();

            UpdateConditionTitles();

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

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}
