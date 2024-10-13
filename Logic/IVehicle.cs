public interface IVehicle
{
  public string GetImagePath();
}
public class Car : IVehicle
{
    public string GetImagePath()
    {
        return "/car.svg";
    }
}
public class Bus : IVehicle
{
    public string GetImagePath()
    {
        return "/bus.svg";
    }
}
public class FireTruck : IVehicle
{
    public string GetImagePath()
    {
        return "/firetruck.svg";
    }
}
public class Taxi : IVehicle
{
    public string GetImagePath()
    {
        return "/taxi.svg";
    }
}
