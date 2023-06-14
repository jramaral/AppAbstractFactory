using AppAbstractFactory.Factory.Interface;
using System.Reflection;
using System.Resources;

namespace AppAbstractFactory.Factory.Cars;

public class CarWindows : IWindows
{
     
    public void CreateWindows()
    {
        Console.WriteLine($"{new ResourceManager(typeof(msg)).GetString("window")}");
    }
}