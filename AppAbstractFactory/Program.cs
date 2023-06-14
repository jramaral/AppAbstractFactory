// See https://aka.ms/new-console-template for more information

using AppAbstractFactory.Factory;

var car = new CarFactory();
var truck = new TruckFactory();
car.CreateBody().CreateBody();
car.CreateChassi().CreateChassi();
car.CreateWindows().CreateWindows();

truck.CreateBody().CreateBody();
truck.CreateChassi().CreateChassi();
truck.CreateWindows().CreateWindows();

Console.WriteLine("Hello, World!");