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
        public SideBarToggle(MainForm form) : base()
        {
            this.Form = form;
        }
        protected override bool CheckCompleted()
        {
            return Math.Round(Form.currentWidth) == Math.Round(Form.targetWidth);
        }

        protected override void Update()
        {
            Form.currentWidth = Utils.Lerp(Form.currentWidth, Form.targetWidth, (1f / (float)AnimationManager.getTimer().Interval) * 3);
            Form.Width = (int)Math.Round(Form.currentWidth);
        }
    }
}
