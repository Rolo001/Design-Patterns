namespace ChainOfResponsibilityApp
{
    public abstract class AbstractStatus
    {
        protected AbstractStatus successor { get; set; }
        public void SetSuccessor(AbstractStatus successor)
        {
            this.successor = successor;
        }

        public void CheckNext(string status)
        {
            if (this.successor != null)
            {
                this.successor.HandleStatus(status);
            }
        }
        public abstract string HandleStatus(string status);
    }
}
