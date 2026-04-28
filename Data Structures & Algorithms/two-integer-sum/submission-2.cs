public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            dic[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (dic.ContainsKey(complement) && dic[complement] != i) {
                return new int[] { i, dic[complement] };
            }
        }
        return new int[0];
    }
}
