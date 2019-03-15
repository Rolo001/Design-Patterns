
using System.Windows.Forms;

namespace ChainOfResponsibilityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            AbstractStatus completed = new StatusCompletedResponsibility();
            AbstractStatus waiting = new StatusWaitingResponsibility();
            AbstractStatus error = new StatusErrorResponsibility();
            AbstractStatus nullStatus = new NullResponsibility();
            completed.SetSuccessor(waiting);
            waiting.SetSuccessor(error);
            error.SetSuccessor(nullStatus);
            string[] status = new
            string[] { "Null", "Waiting", "Error", "Waiting", "Completed" };
        
            foreach(string stat in status)
            {
                label1.Text = completed.HandleStatus(stat);

            }
            
        }
    }
}
