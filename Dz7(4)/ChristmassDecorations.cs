class ChristmassDecorations : ChristmassTreeDecorator
{
    public ChristmassDecorations(IChristmassTree tree) : base(tree)
    { }

    public override string GetChristmassTree()
    {
        string decorations = base.GetChristmassTree();
        decorations += " decorations";
        return decorations;
    }
}
