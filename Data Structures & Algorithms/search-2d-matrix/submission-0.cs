public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int len = matrix[0].Length * matrix.Length - 1;

        return Search(matrix, 0, len, target);
    }

    public bool Search(int[][] matrix, int l, int r, int target) {
        if (l > r) {
            return false;
        }
        int mid = l + (r - l) / 2;
        int row = mid / matrix[0].Length;
        int col = mid % matrix[0].Length;

        if (matrix[row][col] == target) {
            return true;
        }

        int index = row * matrix[0].Length + col;
        return (matrix[row][col] > target) ? Search(matrix, l, index - 1, target)
                                           : Search(matrix, index + 1, r, target);
    }
}
