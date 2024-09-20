using System.Text;

namespace ProgrammingOneReferences
{
    static class MultiDimensionalArray
    {
        // There are times where we need a multi dimensional array.
        // Grids can be a good example of using a 2 dimensional array.
        static string[,] chessBoard = new string[8, 8];

        // We can also iterate throguh the entire board.
        // In this example we can initialize all spaces to empty.
        // Be careful when it comes to nested for loops as they can become quite performant intensive and don't always scale well
        static public void InitializeChessBoard()
        {
            for(int x = 0; x < 8; x++)
            {
                for(int y = 0; y < 8; y++)
                {
                    chessBoard[x, y] = "Empty Space";
                }
            }

            for(int x = 0; x < 8; x++)
            {
                chessBoard[x, 1] = "White Pawn";
                chessBoard[x, 6] = "Black Pawn";

                chessBoard[x, 0] = "White " + ReturnPieceString(x);
                chessBoard[x, 7] = "Black " + ReturnPieceString(x);
            }
        }

        static public void DisplayBoard()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int x = 0;x < 8; x++)
            {
                // New Row
                for(int y = 0;y < 8; y++)
                {
                    stringBuilder.Append(chessBoard[x, y]);
                    if(y < 7)
                    {
                        stringBuilder.Append(" | ");
                    }
                }
                Console.WriteLine(stringBuilder.ToString());
                stringBuilder.Clear();
            }
        }

        // Sometimes when we are repeating similar logic it can be helpful to use functions with parameters
        static string ReturnPieceString(int columnSpace)
        {
            switch (columnSpace)
            {
                case 0:
                    return "Rook";
                case 1:
                    return "Knight";
                case 2:
                    return "Bishop";
                case 3:
                    return "Queen";
                case 4:
                    return "King";
                case 5:
                    return "Bishop";
                case 6:
                    return "Knight";
                case 7:
                    return "Rook";
                default:
                    return "Empty Space";
            }
        }
    }
}
