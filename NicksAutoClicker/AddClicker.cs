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
    public partial class AddClicker : UserControl
    {
        public List<Condition> Conditions = new List<Condition>();
        public AddClicker()
        {
            InitializeComponent();

            comboAction.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {

            Condition con = new Condition(Conditions);
            con.Dock = DockStyle.Top;
            con.Height = 36;
            pnlConditions.Controls.Add(con);
            con.BringToFront();

            UpdateConditionTitles();
        }
    }
}
