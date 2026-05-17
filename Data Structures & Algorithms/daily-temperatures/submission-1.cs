public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] res = new int[len];

        Stack<int[]> stack = new Stack<int[]>();

        for (int i = 0; i < len; i++) {
            int t = temperatures[i];
            while (stack.Count > 0 && stack.Peek()[0] < t) {
                int[] pair = stack.Pop();
                res[pair[1]] = i - pair[1];
            }
            stack.Push(new int[] { t, i });
        }
        return res;
    }
}
