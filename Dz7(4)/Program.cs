IChristmassTree tree = new ChristmassTree();

Console.Write("Enter Y to decorate your christmass tree: ");
Console.ReadLine();
IChristmassTree treeDecorations = new ChristmassDecorations(tree);
Console.WriteLine(treeDecorations.GetChristmassTree());

Console.Write("Enter Y to decorate your christmass tree wit lights: ");
Console.ReadLine();
IChristmassTree treeLights = new ChristmassWithLights(treeDecorations);
Console.WriteLine(treeLights.GetChristmassTree());
