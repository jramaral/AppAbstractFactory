﻿using AppAbstractFactory.Factory.Interface;
using System.Resources;
namespace AppAbstractFactory.Factory.Trucks;

public class TruckChassi: IChassi
{
    public void CreateChassi()
    {
        Console.WriteLine($"{new ResourceManager(typeof(msg)).GetString("chassi")}");
    }
}