public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, HashSet<char>> visitedRow = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> visitedCol = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> visitedSquare = new Dictionary<int, HashSet<char>>();

        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }

                int squareIndicator = (i / 3) * 3 + (j / 3);

                if ((visitedRow.ContainsKey(i) && visitedRow[i].Contains(board[i][j])) ||
                    (visitedCol.ContainsKey(j) && visitedCol[j].Contains(board[i][j])) ||
                    (visitedSquare.ContainsKey(squareIndicator) && visitedSquare[squareIndicator].Contains(board[i][j])))
                {
                    return false;
                }

                if (!visitedRow.ContainsKey(i))
                {
                    visitedRow.Add(i, new HashSet<char>());
                }
                if (!visitedCol.ContainsKey(j))
                {
                    visitedCol.Add(j, new HashSet<char>());
                }
                if (!visitedSquare.ContainsKey(squareIndicator))
                {
                    visitedSquare.Add(squareIndicator, new HashSet<char>());
                }

                visitedRow[i].Add(board[i][j]);
                visitedCol[j].Add(board[i][j]);
                visitedSquare[squareIndicator].Add(board[i][j]);
            }
        }
        return true;
    }
}
