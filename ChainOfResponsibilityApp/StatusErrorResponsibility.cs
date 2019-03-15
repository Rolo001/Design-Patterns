
namespace ChainOfResponsibilityApp
{
    using System;
    class StatusErrorResponsibility : AbstractStatus
    {
        public override string HandleStatus(string status)
        {
            if (status == "Error")
            {
                /// change this line
                Console.WriteLine("Responsibility Error");
                return status;
            }
            this.CheckNext(status);
            return status;
        }
    }
}

