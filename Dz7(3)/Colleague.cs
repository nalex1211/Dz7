namespace Mediator.Examples;

// "Colleague"
abstract class Colleague
{
    protected Mediator mediator;// Constructor
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}