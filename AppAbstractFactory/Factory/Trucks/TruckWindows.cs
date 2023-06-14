using AppAbstractFactory.Factory.Interface;
using System.Resources;
namespace AppAbstractFactory.Factory.Trucks;

public class TruckWindows : IWindows
{
    public void CreateWindows()
    {
        Console.WriteLine($"{new ResourceManager(typeof(msg)).GetString("window")}");
    }
}