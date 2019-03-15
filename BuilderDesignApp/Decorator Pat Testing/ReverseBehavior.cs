using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pat_Testing
{
    public interface IModifyBehavior
    {
        string Apply(string input);
    }

    public class ReverseBehavior : IModifyBehavior
    {
        public virtual string Apply(string input)
        {
            return input + " reverse"; 
        }
    }


    //this is a new class to replace the existing method, without recoding the OG method
    public class LoggingModifyBehavior : IModifyBehavior
    {
        private IModifyBehavior behavior;

        public LoggingModifyBehavior(IModifyBehavior behavior)
        {
            this.behavior = behavior;
        }

        //hello
        public string Apply(string input)
        {
            Debug.WriteLine("Before");
            this.behavior.Apply(input);
            Debug.WriteLine("After");
            return input + " decorator";
        }
    }

}
