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
            ChangeCpsVisibilty(true);

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
            comboAction.SelectedIndex = 0;
            comboDuration.SelectedIndex = 2;
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
            Condition newCondition = new Condition(Conditions);
            newCondition.Dock = DockStyle.Top;
            AddCondition(newCondition);
        }
        void AddCondition(Condition newCondition)
        {

            pnlTriggersList.Controls.Add(newCondition);
            newCondition.AddGutter();
            newCondition.BringToFront();
            UpdateConditionTitles();

        }

        private void btnSwitchToCPS_Click(object sender, EventArgs e)
        {
            ChangeCpsVisibilty(true);
        }

        private void btnSwitchToMS_Click(object sender, EventArgs e)
        {
            ChangeCpsVisibilty(false);
        }
        void ChangeCpsVisibilty(bool state)
        {
            pnlClicksPerSecond.Enabled = state;
            pnlClickIntervalMS.Enabled = !state;

            pnlClicksPerSecond.Visible = state;
            pnlClickIntervalMS.Visible = !state;
        }
        enum DurationOptions
        {
            Forever,
            AmountOfTime,
            Conditions
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDuration.SelectedIndex != (int)DurationOptions.AmountOfTime)
            {
                pnlDurationTime.Enabled = false;
                pnlDurationTime.Hide();
            }
            if (comboDuration.SelectedIndex != (int)DurationOptions.Conditions)
            {
                pnlConditions.Enabled = false;
                pnlConditions.Hide();
            }

            switch ((DurationOptions)comboDuration.SelectedIndex)
            {
                case DurationOptions.Forever:
                    break;
                case DurationOptions.AmountOfTime:
                    pnlDurationTime.Enabled = true;
                    pnlDurationTime.Show();
                    break;
                case DurationOptions.Conditions:
                    pnlConditions.Enabled = true;
                    pnlConditions.Show();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnimationManager.PauseAnimations();
            Popup popup = Popup.Show((MainForm)FindForm(), "Testing");
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
            AnimationManager.ContinueAnimations(FindForm());
        }

    }
}
