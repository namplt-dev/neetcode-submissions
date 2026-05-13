public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0;
        int lMax = 0, rMax = heights.Length - 1;
        while (lMax < rMax) {
            int lower = Math.Min(heights[lMax], heights[rMax]);
            int space = rMax - lMax;

            int max = space * lower;
            res = Math.Max(res, max);

            if (lower == heights[rMax]) {
                rMax--;
            } else {
                lMax++;
            }
        }
        return res;
    }
}
