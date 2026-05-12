public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length - 1;
        while (i < j) {
            int tmp = numbers[i] + numbers[j];
            if (tmp > target) {
                j--;
            }
            if (tmp < target) {
                i++;
            }
            if (tmp == target) {
                return new int[] { ++i, ++j };
            }
        }
        return new int[] {};
    }
}
