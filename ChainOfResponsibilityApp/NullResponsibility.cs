using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityApp
{
    class NullResponsibility : AbstractStatus
    {
        public override string HandleStatus(string status)
        {
            if (status == "Null")
            {
                /// change this line
                Console.WriteLine("Responsibility Null");
                return status;
            }
            this.CheckNext(status);
            return status;
        }
    }
}
