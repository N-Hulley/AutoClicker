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
    public partial class KeyboardListener : UserControl
    {
        private GlobalKeyboardHook _globalKeyboardHook;

        Color defaultBackground = Color.FromArgb(29, 29, 29);
        Color selectedBackground = Color.FromArgb(49, 49, 49);

        public KeyboardListener()
        {
            InitializeComponent();

        }

        private void KeyboardListener_Load(object sender, EventArgs e)
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += keypressed;
        }

        bool listening = false;
        void keypressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (listening)
            {
                //Debug.WriteLine(e.KeyboardData.VirtualCode);

                //if (e.KeyboardData.VirtualCode != GlobalKeyboardHook.VkSnapshot)
                //    return;
                KeysConverter kc = new KeysConverter();

                label1.Text = kc.ConvertToString((Keys)e.KeyboardData.VirtualCode);
                e.Handled = true;

            }
        }

        public void Dispose()
        {
            _globalKeyboardHook?.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyboardListener_Enter(object sender, EventArgs e)
        {
            listening = true;
            BackColor = selectedBackground;
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void KeyboardListener_Leave(object sender, EventArgs e)
        {
            listening = false;
            BackColor = defaultBackground;
            BorderStyle = BorderStyle.None;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (listening)
                KeyboardListener_Leave(sender, e);
            else
                KeyboardListener_Enter(sender, e);
        }
    }
}
