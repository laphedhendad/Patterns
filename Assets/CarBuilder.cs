public class CarBuilder:IVehicleBuilder
{
    private Car _car;
    
    public void Reset()
    {
        _car = new Car();
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

    public Car GetResult()
    {
        return _car;
    }
}

public class Car
{
    
}
