using AppAbstractFactory.Factory.Interface;
using System.Resources;
namespace AppAbstractFactory.Factory.Trucks;

public class TruckBody : IBody
{
    public void CreateBody()
    {
        Console.WriteLine($"{new ResourceManager(typeof(msg)).GetString("body")}");
    }
}