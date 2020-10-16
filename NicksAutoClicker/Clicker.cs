using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicksAutoClicker
{
    public enum ConditionTypes
    {
        activeWhileAllConditionsMet,
        toggleWhenAllConditionsMet,
        activeWhileAnyConditionMet,
        toggleWhenAnyConditionMet
    }
    public class Clicker
    {
        public string Title { get; set; }
        public ConditionTypes ConditionType { get; set; }
    }
}
