using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUtils;

namespace NicksAutoClicker
{
    public static class DrawingSuspensions
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
    public static class Utils
    {
        public static Point CenterForm(Form Parent, Form Child)
        {
            return new Point(
                (Parent.DesktopLocation.X - Parent.Width / 2) - (Child.Width / 2),
                (Parent.DesktopLocation.Y - Parent.Height / 2) - (Child.Height / 2)
            );
        }
        public static float Lerp(float v1, float v2, float t)
        {
            return v1 + ((v2 - v1) * t);
        }
        internal static void ApplyLayeredWindowHelp(Form form, bool designMode)
        {
            if (!designMode)
            {
                LayeredWindowHelper helper;
                helper = new LayeredWindowHelper(form);
                (helper).BackColor = Color.FromArgb(200, Color.Black);
                Win7Style.EnableBlurBehindWindow(form.Handle);
                Win10Style.EnableBlur(form.Handle);
            }
        }

        public class BetterTimer
        {
            private delegate void TimerEventDel(int id, int msg, IntPtr user, int dw1, int dw2);
            private const int TIME_PERIODIC = 1;
            private const int EVENT_TYPE = TIME_PERIODIC;// + 0x100;  // TIME_KILL_SYNCHRONOUS causes a hang ?!
            [DllImport("winmm.dll")]
            private static extern int timeBeginPeriod(int msec);
            [DllImport("winmm.dll")]
            private static extern int timeEndPeriod(int msec);
            [DllImport("winmm.dll")]
            private static extern int timeSetEvent(int delay, int resolution, TimerEventDel handler, IntPtr user, int eventType);
            [DllImport("winmm.dll")]
            private static extern int timeKillEvent(int id);

            internal void Cancel()
            {
                int err = timeKillEvent(mTimerId);
                timeEndPeriod(1);
            }

            Action mAction;
            Form mForm;
            private int mTimerId;
            private TimerEventDel mHandler;  // NOTE: declare at class scope so garbage collector doesn't release it!!!

            public BetterTimer(Form form, Action action, int delay)
            {
                mAction = action;
                mForm = form;
                timeBeginPeriod(1);
                mHandler = new TimerEventDel(TimerCallback);
                mTimerId = timeSetEvent(delay, 0, mHandler, IntPtr.Zero, EVENT_TYPE);
            }

            public void Stop()
            {
                int err = timeKillEvent(mTimerId);
                timeEndPeriod(1);
                System.Threading.Thread.Sleep(100);// Ensure callbacks are drained
            }

            private void TimerCallback(int id, int msg, IntPtr user, int dw1, int dw2)
            {
                if (mTimerId != 0)
                    mForm.BeginInvoke(mAction);
            }
        }
    }
    namespace EventListArgs
    {
        public class ItemAdded<T> : EventArgs
        {
            public T Item { get; set; }

            public ItemAdded(T item)
            {
                Item = item;
            }
        }
    }
    public class EventList<T> : List<T> 
    {
        public event EventHandler onAdd; 
        public new void Add(T item)
        {
            base.Add(item);
            EventListArgs.ItemAdded<T> args = new EventListArgs.ItemAdded<T>(item);
            onAdd.Invoke(this, args);

        }
    }
}
