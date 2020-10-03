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
        ComboBox ConditionalAction;

        private void comboIndicator_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Key Is Down
            //Mouse Button Down
            if (ConditionalAction != null)
            {
                ((Control)sender).Parent.Controls.RemoveByKey(ConditionalAction.Name);

                ConditionalAction = null;
            }
            switch (comboIndicator.SelectedIndex)
            {
                case 0:
                    ConditionalAction = new ComboBox();

                    ConditionalAction.Items.AddRange(
                        new string[] { "Left", "Right", "Middle", "Scroll Up", "Scroll Down" });

                    ConditionalAction.SelectedIndex = 0;
                    ConditionalAction.Name = "comboConditionAction";
                    ConditionalAction.Dock = DockStyle.Left;
                    ConditionalAction.SendToBack();
                    ((Control)sender).Parent.Controls.Add(ConditionalAction);
                    break;
                case 1:

                    break;
            }
        }
    }
}
