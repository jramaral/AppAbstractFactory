using AppAbstractFactory.Factory.Interface;
using System.Resources;
namespace AppAbstractFactory.Factory.Cars;

public class CarChassi : IChassi
{
    public void CreateChassi()
    {
        Console.WriteLine($"{ new ResourceManager(typeof(msg)).GetString("chassi")}");
    }
}