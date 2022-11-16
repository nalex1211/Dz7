

class PieceCreator
{
    private int numOfPieces = Random.Shared.Next(5, 20);
    private int defectedPieces = Random.Shared.Next(1, 4);
    public void CreatePieces()
    {
        Console.WriteLine($"Created {numOfPieces} successfully");
    }
    public void MarkPiece()
    {
        int checkedPieces = numOfPieces - defectedPieces;
        Console.WriteLine($"Pieces marked. {checkedPieces} out of {numOfPieces} pieces are valid");
    }
}
