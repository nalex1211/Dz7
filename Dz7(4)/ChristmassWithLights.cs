class ChristmassWithLights : ChristmassTreeDecorator
{
    public ChristmassWithLights(IChristmassTree tree) : base(tree)
    { }

    public override string GetChristmassTree()
    {
        string decorations = base.GetChristmassTree();
        decorations += " and lights";
        return decorations;
    }
}
