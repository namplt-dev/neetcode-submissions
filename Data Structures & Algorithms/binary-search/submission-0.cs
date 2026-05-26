public class Solution {
    public int Search(int[] nums, int target) {
        int res = nums.Length / 2;
        if (nums[res] == target) {
            return res;
        } else if (nums[res] > target) {
            while (res > 0) {
                res--;
                if (nums[res] == target) {
                    return res;
                }
            }
        } else {
            while (res < nums.Length - 1) {
                res++;
                if (nums[res] == target) {
                    return res;
                }
            }
        }
        return -1;
    }
}
