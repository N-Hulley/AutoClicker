using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksAutoClicker.Animations
{
    class SideBarToggle : UniqueAnimation
    {
        MainForm Form;
        public SideBarToggle(bool instantCompletion, MainForm form) : base(form,instantCompletion)
        {
            this.Form = form;
            if (t == null)
            {
                InstantComplete();
            }
        }

        public override void InstantComplete()
        {
            Form.currentWidth = Form.targetWidth;
            Form.Width = (int)Form.currentWidth;
            Completed = true;
            AnimationManager.ActiveAnimations.Remove(this);
        }

        protected override bool CheckCompleted()
        {
            if (Math.Abs(Form.Width - Form.targetWidth) <= 5)
            {
                InstantComplete();
                return true;
            }
            return false;
        }


    protected override void Update()
        {
            //if (Form.Width < Form.targetWidth) Form.Width+=5; else Form.Width-=5;
            Form.Width = (int)Utils.Lerp(Form.Width, Form.targetWidth, (1f / UserSettings.AnimationInterval) * 5);
        }
    }
}
