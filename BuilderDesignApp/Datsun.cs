using System;

namespace BuilderDesignApp
{
    /// <summary>
    /// The 'ConcreteBuilder'
    /// </summary>
     class DatsunBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle("Datsun 240Z");

        public void BuildBrakeSystem()
        {
            vehicle["Brakes"] = "ABS";
        }

        public void BuildEngine()
        {
            //temporary filler
            vehicle["Engine"] = "inline 6 Nissan (temp)";
        }  

        public void BuildSteering()
        {
            vehicle["Steering"] = "Direct drive";
        }

        public void BuildWheels()
        {
            vehicle["Wheels"] = "Pirelli"; 
        }

        public Vehicle GetResult()
        {
            return vehicle;
        }
    }
}
