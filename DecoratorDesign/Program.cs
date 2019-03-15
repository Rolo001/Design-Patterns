using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseBehavior on = new ReverseBehavior();
            LoggingModifyBehavior onset = new LoggingModifyBehavior(on);


            Console.WriteLine("Enter word:\n");
            string word = Console.ReadLine().ToString();


            Console.WriteLine("\nThe word is: {0} \n", on.Apply(word));
            Console.WriteLine("\nThe word is: {0} \n", onset.Apply(word));

            Console.ReadKey();
        }
    }
}
