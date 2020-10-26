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
        List<Condition> Conditions;
        KeyboardListener keyboardInput = new KeyboardListener();
        ComboBox ConditionalAction;

        TransparentControl AdjacentGutter;
        public void AddGutter()
        {
            AdjacentGutter = new TransparentControl();
            AdjacentGutter.Height = Conditions.Count > 1 ? 2 : 5;
            AdjacentGutter.Dock = DockStyle.Top;
            AdjacentGutter.BackColor = Color.Transparent;
            AdjacentGutter.Name = "conditionGutter-" + Conditions.Count.ToString();
            this.Parent.Controls.Add(AdjacentGutter);
            AdjacentGutter.BringToFront();
        }
        public Condition(List<Condition> conditions)
        {
            conditions.Add(this);
            this.Conditions = conditions;

            InitializeComponent();

            ConditionalAction = new ComboBox();
            ConditionalAction.Items.AddRange(
                new string[] { "Left", "Right", "Middle", "Scroll Up", "Scroll Down" });
            ConditionalAction.SelectedIndex = 0;
            ConditionalAction.Name = "comboConditionAction";
            ConditionalAction.Dock = DockStyle.Left;
            ConditionalAction.BackColor = comboIndicator.BackColor;
            ConditionalAction.Font = comboIndicator.Font;
            ConditionalAction.FlatStyle = comboIndicator.FlatStyle;
            ConditionalAction.ForeColor = comboIndicator.ForeColor;
            ConditionalAction.Width = 100;

            keyboardInput = new KeyboardListener();
            keyboardInput.Dock = DockStyle.Left;
            keyboardInput.Width = 100;
            keyboardInput.Margin = new Padding(0,0,15,0);
            comboIndicator.Parent.Controls.Add(ConditionalAction);
            comboIndicator.Parent.Controls.Add(keyboardInput);

            ConditionalAction.BringToFront();
            ConditionalAction.Hide();
            keyboardInput.BringToFront();
            keyboardInput.Hide();

            comboIndicator.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conditions.Remove(this);
            ((AddClicker)((MainForm)this.FindForm()).SideBarControl).UpdateConditionTitles();
            this.Parent.Controls.Remove(AdjacentGutter);
            this.Parent.Controls.Remove(this);
            
        }

        private void Condition_Load(object sender, EventArgs e)
        {
        }

        private void comboIndicator_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderCombo = (ComboBox)sender;
            //Key Is Down
            //Mouse Button Down

            keyboardInput.Hide();
            ConditionalAction.Hide();

            switch (comboIndicator.SelectedIndex)
            {
                case 0:
                    keyboardInput.Show();
                    keyboardInput.Focus();
                    break;
                case 1:
                    ConditionalAction.Show();
                    ConditionalAction.Focus();
                    
                    break;
            }
        }
    }
}
