namespace StrategyDesignApp.BrandClasses
{
    using System;
    class ToyotaCars : IBrandStrategy
    {
        public void DisplayModel(string brand)
        {
            Console.WriteLine("Cars for {0}:\n", brand);
            Console.WriteLine("> HiAce");
            Console.WriteLine("> AE86");
            Console.WriteLine("> Camry");
            Console.WriteLine("> Altis");
            Console.WriteLine("> FRS");
            Console.ReadKey();

        }
    }
}
