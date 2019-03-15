
namespace DecoratorDesign
    
{
    using System.Diagnostics;
    class LoggingModifyBehavior : IModifyBehavior
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
