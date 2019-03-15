using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesign
{
    class ReverseBehavior : IModifyBehavior
    {
        public virtual string Apply(string input)
        {
            return input + " reverse";
        }
    }
}
