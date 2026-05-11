public class Solution {
    public bool IsPalindrome(string s) {
        char[] chars = s.ToLower().ToCharArray();
        Stack<char> stack = new Stack<char>();
        StringBuilder osf = new StringBuilder("");

        for (int i = 0; i < chars.Length; i++) {
            if (char.IsLetterOrDigit(chars[i])) {
                stack.Push(chars[i]);
                osf.Append(chars[i]);
            }
        }

        StringBuilder sb = new StringBuilder("");
        while (stack.Count > 0) {
            sb.Append(stack.Pop());
        }

        if (!osf.Equals(sb)) {
            return false;
        }
        return true;
    }
}
