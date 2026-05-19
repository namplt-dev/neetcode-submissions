public class Solution {
    public int Trap(int[] height) {
        int res = 0;
        int len = height.Length;
        int l = 0, r = len - 1;
        int maxL = height[l], maxR = height[r];
        while (l < r) {
            if (maxL < maxR) {
                l++;
                maxL = Math.Max(maxL, height[l]);
                res += maxL - height[l];
            } else {
                r--;
                maxR = Math.Max(maxR, height[r]);
                res += maxR - height[r];
            }
        }
        return res;
    }
}
