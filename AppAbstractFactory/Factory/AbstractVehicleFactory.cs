using AppAbstractFactory.Factory.Interface;

namespace AppAbstractFactory.Factory;

public abstract class AbstractVehicleFactory
{
    public abstract IBody CreateBody();
    public abstract IChassi CreateChassi();
    public abstract IWindows CreateWindows();
    
}