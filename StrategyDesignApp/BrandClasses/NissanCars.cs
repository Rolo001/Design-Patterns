using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignApp.BrandClasses
{
    class NissanCars : IBrandStrategy
    {
        public void DisplayModel(string brand)
        {
            Console.WriteLine("Cars for {0}: \n", brand);
            Console.WriteLine("> GTR");
            Console.WriteLine("> Skyline");
            Console.WriteLine("> Stanza");
            Console.WriteLine("> NV350");
            Console.WriteLine("> 240Z");
            Console.ReadKey();
        }
    }
}
