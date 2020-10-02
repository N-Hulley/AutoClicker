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
    public partial class Condition : UserControl
    {
        public Condition()
        {
            InitializeComponent();
            comboIndicator.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentForm.Controls.Remove(this);
        }

        private void Condition_Load(object sender, EventArgs e)
        {

        }
    }
}
