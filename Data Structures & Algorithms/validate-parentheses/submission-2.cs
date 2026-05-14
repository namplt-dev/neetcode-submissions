public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> constants =
            new Dictionary<char, char> { { '[', ']' }, { '(', ')' }, { '{', '}' } };

        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (constants.ContainsKey(c)) {
                stack.Push(c);
            } else {
                if (stack.Count == 0 || constants[stack.Pop()] != c) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
