public class PlaneBuilder:IVehicleBuilder
{
    private Plane _plane;
    
    public void Reset()
    {
        _plane = new Plane();
    }

    public void SetBase()
    {

    }

    public void SetWheels()
    {

    }

    public void SetEngine()
    {

    }

    public void SetSeats()
    {

    }

    public Plane GetResult()
    {
        return _plane;
    }
}

public class Plane
{
    
}
