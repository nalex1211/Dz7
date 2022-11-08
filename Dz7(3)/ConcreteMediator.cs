﻿namespace Mediator.Examples;

// "ConcreteMediator"
class ConcreteMediator : Mediator
{
    private ConcreteColleague1 colleague1;
    private ConcreteColleague2 colleague2;
    private ConcreteColleague3 colleague3;
    public ConcreteColleague1 Colleague1
    {
        set { colleague1 = value; }
    }
    public ConcreteColleague2 Colleague2
    {
        set { colleague2 = value; }
    }
    public ConcreteColleague3 Colleague3
    {
        set { colleague3 = value; }
    }
    public override void Send(string message, Colleague colleague)
    {
        if (colleague == colleague1)
        {
            colleague2.Notify(message);
        }
        else if(colleague == colleague2)
        {
            colleague1.Notify(message);
        }
        else
        {
            colleague3.Notify(message);
        }

    }
}