namespace StrategyDesignApp
{
    using System;
    using StrategyDesignApp.BrandClasses;
    class Program
    {
        static void Main(string[] args)
        {
            string brand;
            IBrandStrategy brandStrategy;
            Console.WriteLine("Please input car brand or END to close program");
            do
            {
                brand = Console.ReadLine();

                switch (brand.ToLower())
                {
                    case "toyota":
                        brandStrategy = new ToyotaCars();
                        brandStrategy.DisplayModel(brand);
                        break;

                    case "nissan":
                        brandStrategy = new ToyotaCars();
                        brandStrategy.DisplayModel(brand);
                        break;

                    default:
                        Console.WriteLine("No list for the brand.");
                        break;
                }
                
            }
            while (brand != "END");
        }
    }
}
