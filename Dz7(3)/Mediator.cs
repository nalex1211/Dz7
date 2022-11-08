namespace Mediator.Examples;

// "Mediator"
abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}