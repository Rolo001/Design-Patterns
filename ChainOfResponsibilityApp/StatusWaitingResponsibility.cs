using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityApp
{
    class StatusWaitingResponsibility : AbstractStatus
    {
        public override string HandleStatus(string status)
        {
            if (status == "Waiting")
            {
                /// change this line
                Console.WriteLine("Responsibility Waiting");
                return status;
            }
            this.CheckNext(status);
            return status;
        }
    }
}
