using AppAbstractFactory.Factory.Cars;
using AppAbstractFactory.Factory.Interface;

namespace AppAbstractFactory.Factory;

public class CarFactory : AbstractVehicleFactory
{
    public override IBody CreateBody()
    {
        return new CarBody();
    }

    public override IChassi CreateChassi()
    {
        return new CarChassi();
    }

    public override IWindows CreateWindows()
    {
        return new CarWindows();
    }
}