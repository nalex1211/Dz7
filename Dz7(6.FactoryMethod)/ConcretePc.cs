using static Dz7_6.FactoryMethod_.Constants;

public class ConcretePc : Creator
{
    public override Pc FactoryMethod(string choice)
    {
        switch (choice)
        {
            case Choices._Intel:
            return new IntelPc();

            case Choices._Amd:
            return new AmdPc();

            default: throw new ArgumentException("Invalid type.", "type");
        }
    }
}
