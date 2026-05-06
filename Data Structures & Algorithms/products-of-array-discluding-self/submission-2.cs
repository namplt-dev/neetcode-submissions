public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int numsLength = nums.Length;
        int[] result = new int[numsLength];
        Array.Fill(result, 1);

        int prefix = 1;
        for (int i = 0; i < numsLength; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }
        int suffix = 1;
        for (int i = numsLength - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }
        return result;
    }
}