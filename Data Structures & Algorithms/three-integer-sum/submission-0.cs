public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        int len = nums.Length;

        for (int i = 0; i < len - 2; i++) {
            for (int j = i + 1; j < len - 1; j++) {
                int findNum = 0 - (nums[i] + nums[j]);
                int k = j + 1;
                while (k < len) {
                    if (nums[k] == findNum) {
                        List<int> triplets = new List<int>() { nums[i], nums[j], nums[k] };
                        triplets.Sort();
                        if (!res.Any(x => x.SequenceEqual(triplets))) {
                            res.Add(triplets);
                        }
                    }
                    k++;
                }
            }
        }
        return res;
    }
}
