class RegularCarCreator : Creator
{
    public override IProduct Create()
    {
        return new RegularCar();
    }
}
