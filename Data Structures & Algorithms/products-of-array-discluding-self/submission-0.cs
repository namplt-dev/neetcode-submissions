public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            var product = 1;
            for (int j = 0; j < nums.Length; j++) {
                if (i != j) {
                    product *= nums[j];
                }
                if (product == 0) {
                    break;
                }
            }
            result[i] = product;
        }
        return result;
    }
}