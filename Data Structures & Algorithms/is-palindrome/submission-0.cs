public class Solution {
    public bool IsPalindrome(string s) {
        char[] chars = s.ToLower().ToCharArray();
        int start = 0, end = chars.Length - 1;

        while (start < chars.Length || end >= 0) {
            while (start < chars.Length && !char.IsLetterOrDigit(chars[start])) {
                start++;
            }
            while (end >= 0 && !char.IsLetterOrDigit(chars[end])) {
                end--;
            }
            if (start < chars.Length && end >= 0){
                if (!chars[start].Equals(chars[end])) {
                    return false;
                }
            }
            start++;
            end--;
        }
        return true;
    }
}
