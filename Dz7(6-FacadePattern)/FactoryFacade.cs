

class FactoryFacade
{
    Factory factory;
    PieceCreator pieceCreator;
    PiecePaint piecePaint;
    public FactoryFacade(Factory factory, PieceCreator pieceCreator, PiecePaint piecePaint)
    {
        this.factory = factory;
        this.pieceCreator = pieceCreator;
        this.piecePaint = piecePaint;
    }

    public void Start()
    {
        factory.StartConveyor();
        pieceCreator.CreatePieces();
        pieceCreator.MarkPiece();
        piecePaint.PaintPiece();
    }
    public void Stop()
    {
        factory.StopConveyor();
    }
}
