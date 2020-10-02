using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            Condition con = new Condition();
            con.Dock = DockStyle.Top;

            pnlConditions.Controls.Add(con);
            con.BringToFront();
        }
    }
}
