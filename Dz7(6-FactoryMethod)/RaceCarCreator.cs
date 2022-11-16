class RaceCarCreator : Creator
{
    public override IProduct Create()
    {
        return new RaceCar();
    }
}
