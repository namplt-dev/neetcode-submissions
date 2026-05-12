public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);

        int f = 0;
        while (f < nums.Length) {
            if (nums[f] > 0) {
                break;
            }
            if (f > 0 && nums[f] == nums[f - 1]) {
                f++;
                continue;
            }
            int l = f + 1, r = nums.Length - 1;
            while (l < r) {
                int sum = nums[f] + nums[l] + nums[r];
                if (sum < 0) {
                    l++;
                } else if (sum > 0) {
                    r--;
                } else {
                    res.Add(new List<int> { nums[f], nums[l], nums[r] });
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1]) {
                        l++;
                    }
                }
            }
            f++;
        }
        return res;
    }
}
