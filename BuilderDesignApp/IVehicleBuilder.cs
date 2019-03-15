namespace BuilderDesignApp
{

    /// <summary>
    /// The 'Builder' 
    /// </summary>
    interface IVehicleBuilder
    {
        void BuildEngine();
        void BuildWheels();
        void BuildSteering();
        void BuildBrakeSystem();

        Vehicle GetResult();
        
    }
}
