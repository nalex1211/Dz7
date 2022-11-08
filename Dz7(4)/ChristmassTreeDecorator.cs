class ChristmassTreeDecorator : IChristmassTree
{
    private IChristmassTree? _tree;

    public ChristmassTreeDecorator(IChristmassTree? tree)
    {
        _tree = tree;
    }

    public virtual string GetChristmassTree()
    {
        return _tree.GetChristmassTree();
    }
}
