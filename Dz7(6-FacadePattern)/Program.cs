Factory factory = new Factory();
PieceCreator pieceCreator = new PieceCreator();
PiecePaint piecePaint = new PiecePaint();

FactoryFacade facade = new FactoryFacade(factory, pieceCreator, piecePaint);

Worker worker = new Worker();
worker.Work(facade);
