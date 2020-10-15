using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksAutoClicker.Animations
{
    /// <summary>
    /// An animation which is only allowed a single instance to exist at a time
    /// </summary>
    public abstract class UniqueAnimation : Animation
    { 
        public UniqueAnimation(bool overridePrevious = true) {
            for (int i = AnimationManager.ActiveAnimations.Count-1; i >= 0; --i)
            {
                if (AnimationManager.ActiveAnimations[i].GetType() == this.GetType())
                {
                    if (overridePrevious)
                    {
                        AnimationManager.ActiveAnimations[i] = this;
                    }
                    return;
                }
            }
            AnimationManager.ActiveAnimations.Add(this);
        }
    }
}
