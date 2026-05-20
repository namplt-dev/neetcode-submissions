public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int res = 0;
        Stack<int[]> stack = new Stack<int[]>();
        for (int i = 0; i < heights.Length; i++) {
            int start = i;
            while (stack.Count > 0 && stack.Peek()[1] > heights[i]) {
                int[] top = stack.Pop();
                int index = top[0];
                int height = top[1];
                res = Math.Max(res, height * (i - index));
                start = index;
            }
            stack.Push(new int[] { start, heights[i] });
        }

        foreach (var p in stack) {
            int index = p[0];
            int height = p[1];
            res = Math.Max(res, height * (heights.Length - index));
        }
        return res;
    }
}
