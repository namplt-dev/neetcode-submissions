public class Solution {
    public int LongestConsecutive(int[] nums) {
        int res = 0;
        HashSet<int> set = new HashSet<int>(nums);

        int i = 0;
        while (i < nums.Length) {
            int maxRes = 0;
            int complement = nums[i] - 1;
            while (set.Contains(complement)) {
                maxRes++;
                complement--;
            }

            if (maxRes >= res) {
                res = maxRes + 1;
            }
            i++;
        }
        return res;
    }
}