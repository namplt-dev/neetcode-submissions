public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new HashSet<int>(nums);

        for (int i = 0; i < nums.Length; i++) {
            var complement = target - nums[i];
            if (hash.Contains(complement)) {
                if (complement == nums[i]) {
                    for (int j = i + 1; j < nums.Length; j++) {
                        if (nums[j] == complement) {
                            return new int[] { i, j };
                        }
                    }
                } else {
                    return new int[] { i, Array.IndexOf(nums, complement) };
                }
            }
        }
        return new int[0];
    }
}
