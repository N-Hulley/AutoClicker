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
    public partial class Popup : Form
    {
        public event EventHandler PopupClosed;


        public static Popup Show(Form parent, string title)
        {
            Popup popup = new Popup();
            popup.titleBar1.Title = title;
            popup.ShowDialog();
            popup.Location = new Point(
                (parent.Location.X + parent.Width / 2) - popup.Width/2,
                (parent.Location.Y + parent.Height / 2) - popup.Height / 2
            );
            
            return popup;
        }
        public void CancelPopup()
        {
            PopupClosedEventArgs args = new PopupClosedEventArgs();
            args.method = PopupClosedMethod.Canceled;
            FinishEvent(args);
        }
        private void FinishEvent(PopupClosedEventArgs args)
        {
            PopupClosed.Invoke(this, args);
        }
        public Popup()
        {
            InitializeComponent();
        }

        private void titleBar1_Load_1(object sender, EventArgs e)
        {

        }
    }


    public enum PopupClosedMethod
    {
        Canceled,
        Completed
    };
    public class PopupClosedEventArgs : EventArgs
    {
        public PopupClosedMethod method;
    }
}
