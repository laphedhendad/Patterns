public class VehicleBuildingDirector
{
    //to get new vehicle create builder, construct object with Director and get result using builder.GetResult() in client code
    
    public void MakeSportsCar(IVehicleBuilder builder)
    {
        builder.Reset();
        builder.SetBase();
        builder.SetWheels();
    }

    public void MakePlane(IVehicleBuilder builder)
    {
        //setup new plane
    }
}
