public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
        int res = 0;
        for (int i = 0; i < heights.Length; i++) {
            int min = heights[i];
            res = Math.Max(res, heights[i]);
            for (int j = i + 1; j < heights.Length; j++) {
                min = Math.Min(min, heights[j]);
                res = Math.Max(res, min * (j - i + 1));
            }
        }
        return res;
    }
}
