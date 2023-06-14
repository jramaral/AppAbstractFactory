using AppAbstractFactory.Factory.Interface;
using System.Resources;
namespace AppAbstractFactory.Factory.Cars;

public class CarBody : IBody
{
    public void CreateBody()
    {
        Console.WriteLine($"{new ResourceManager(typeof(msg)).GetString("body")}");
    }
}