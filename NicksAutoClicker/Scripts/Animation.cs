using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicksAutoClicker
{

    public static class AnimationManager
    {
        private static System.Windows.Forms.Timer AnimationTimer;
        public static EventList<Animation> ActiveAnimations = new EventList<Animation>();
        static AnimationManager()
        {
            ActiveAnimations.onAdd += AnimationAdded;
        }
        static void AnimationAdded(object sender, EventArgs e)
        {

            //Animation newAnimation = ((EventListArgs.ItemAdded<Animation>)e).Item;
            //if (!AnimationTimer.Enabled) AnimationTimer.Start();

        }
        public static void PauseAnimations()
        {
            AnimationTimer.Stop();

        }
        public static void ContinueAnimations()
        {
            AnimationTimer.Start();

        }
        public static void setTimer(System.Windows.Forms.Timer t) {
            AnimationTimer = t;
            AnimationTimer.Tick += Animation_Tick;
            AnimationTimer.Disposed += Timer_Destroyed;
            if(ActiveAnimations.Count > 0) AnimationTimer.Start(); 
        }
        public static System.Windows.Forms.Timer getTimer()
        {
            return AnimationTimer;
        }
        static void Timer_Destroyed(object sender, EventArgs e)
        {
            ActiveAnimations.Clear();
        }
        static void Animation_Tick(object sender, EventArgs e)
        {
            //if (ActiveAnimations.Count <= 0)
            //    AnimationTimer.Stop();

            //else for (int i = ActiveAnimations.Count - 1; i >= 0; i--)
            //    {
            //        ActiveAnimations[i].Step();
            //        if (ActiveAnimations[i].Completed)
            //            ActiveAnimations.RemoveAt(i);
            //    }
        }
    }
    public class AnimationCompleteEventArgs : EventArgs
    {
        public AnimationCompleteEventArgs()
        {
        }
    }
    public abstract class Animation
    {
        public event EventHandler AnimationComplete;
        public event EventHandler AnimationCanceled;
        public bool Completed = false;
        public int Itterations = 0;
        public bool InstantCompletion = false;
        public Thread thr;
        public Animation(bool instantCompletion)
        {
            InstantCompletion = instantCompletion;
            thr = new Thread(new ThreadStart(ThreadStep));
            thr.Start();
        }
        public void ThreadStep()
        {
            Step();
            Thread.Sleep(17);
        }

        public void Cancel()
        {
            thr.Abort();
            if (AnimationCanceled != null)
            {
                AnimationCompleteEventArgs args = new AnimationCompleteEventArgs();
                AnimationCanceled.Invoke(this, args);
            }
            AnimationManager.ActiveAnimations.Remove(this);
        }
        public void Step() {
            Itterations++;
            if (InstantCompletion || UserSettings.InstantAnimation) InstantComplete();
            Completed = CheckCompleted();
            
            if (Completed && AnimationComplete != null)
            {
                AnimationCompleteEventArgs args = new AnimationCompleteEventArgs();
                AnimationComplete.Invoke(this, args);
            }
            this.Update();

        }
        public abstract void InstantComplete();
        protected abstract void Update();

        protected abstract bool CheckCompleted();

    }
}
