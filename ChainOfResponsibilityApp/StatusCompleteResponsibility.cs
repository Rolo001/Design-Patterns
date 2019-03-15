using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityApp
{
    public class StatusCompletedResponsibility : AbstractStatus
    {
        public override string HandleStatus(string status)
        {
            if (status == "Completed")
            {
                /// change this line
                Console.WriteLine("Responsibility Completed");
                return status;
            }
            this.CheckNext(status);
            return status;
        }
    }
}
