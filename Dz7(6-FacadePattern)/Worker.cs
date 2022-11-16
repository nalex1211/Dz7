

class Worker
{
    public void Work(FactoryFacade factory)
    {
        factory.Start();
        factory.Stop();
    }
}