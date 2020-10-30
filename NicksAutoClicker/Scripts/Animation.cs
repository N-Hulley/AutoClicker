using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static NicksAutoClicker.Utils;

namespace NicksAutoClicker
{

    public static class AnimationManager
    {
        public static EventList<Animation> ActiveAnimations = new EventList<Animation>();
        static AnimationManager()
        {
            ActiveAnimations.onAdd += AnimationAdded;
        }
        static void AnimationAdded(object sender, EventArgs e)
        {

            //Animation newAnimation = ((EventListArgs.ItemAdded<Animation>)e).Item;
        }
        public static void PauseAnimations()
        {
            foreach(Animation anim in ActiveAnimations)
            {
                anim.Pause();
            }

        }
        public static void ContinueAnimations(Form f)
        {
            foreach (Animation anim in ActiveAnimations)
            {
                anim.Resume(f);
            }


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
        protected BetterTimer t;
        protected float DeltaTime = 1f;
        DateTime last = DateTime.Now;
        DateTime now = DateTime.Now;
        public Animation(Form f,bool instantCompletion)
        {
            InstantCompletion = instantCompletion;
            if (!InstantCompletion && !UserSettings.InstantAnimation) { 
                t = new BetterTimer(f, Step, UserSettings.AnimationInterval);
            }
        }
        public void Cancel(bool autoFinish = false)
        {
            t.Cancel();
            t = null;
            if (autoFinish) InstantComplete();
            if (AnimationCanceled != null)
            {
                AnimationCompleteEventArgs args = new AnimationCompleteEventArgs();
                AnimationCanceled.Invoke(this, args);
            }
            AnimationManager.ActiveAnimations.Remove(this);
        }
        public void Step()
        {

            if (t == null) return;

            else
            {
                last = now;
                now = DateTime.Now;
                float deltaTime = (now.Ticks - last.Ticks) / 10000000f;
                this.Update();
            }
            Completed = CheckCompleted();
            
            if (Completed && AnimationComplete != null)
            {
                t.Cancel();
                t = null;
                AnimationCompleteEventArgs args = new AnimationCompleteEventArgs();
                AnimationComplete.Invoke(this, args);
                AnimationManager.ActiveAnimations.Remove(this);
                return;
            }
            Itterations++;

        }
        public abstract void InstantComplete();
        protected abstract void Update();

        protected abstract bool CheckCompleted();

        public void Pause()
        {
            t.Stop();
        }

        public void Resume(Form f)
        {
            t = new BetterTimer(f, Step, UserSettings.AnimationInterval);
        }
    }
}
