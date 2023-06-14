using AppAbstractFactory.Factory.Interface;
using AppAbstractFactory.Factory.Trucks;

namespace AppAbstractFactory.Factory;

public class TruckFactory : AbstractVehicleFactory
{
    public override IBody CreateBody()
    {
        return new TruckBody();
    }

    public override IChassi CreateChassi()
    {
        return new TruckChassi();
    }

    public override IWindows CreateWindows()
    {
        return new TruckWindows();
    }
}