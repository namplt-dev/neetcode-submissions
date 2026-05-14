public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0)
            return false;

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') {
                stack.Push(s[i]);
            }
            if (s[i] == ')') {
                if (stack.Count == 0 || stack.Pop() != '(') {
                    return false;
                }
            }
            if (s[i] == ']') {
                if (stack.Count == 0 || stack.Pop() != '[') {
                    return false;
                }
            }
            if (s[i] == '}') {
                if (stack.Count == 0 || stack.Pop() != '{') {
                    return false;
                }
            }
        }

        if (stack.Count > 0) {
            return false;
        }
        return true;
    }
}
