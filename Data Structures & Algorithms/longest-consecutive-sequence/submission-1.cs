public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int res = 0;

        foreach (int x in set) {
            if (!set.Contains(x - 1)) {
                var count = 1;
                while (set.Contains(x + count)) {
                    count++;
                }
                res = Math.Max(res, count);
            }
        }
        return res;
    }
}