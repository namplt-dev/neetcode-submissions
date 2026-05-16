public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> number = new Stack<int>();

        foreach (string token in tokens) {
            if (token == "+" || token == "-" || token == "*" || token == "/") {
                int first = number.Pop();
                int second = number.Pop();

                switch (token) {
                    case "+":
                        number.Push(second + first);
                        break;
                    case "-":
                        number.Push(second - first);
                        break;
                    case "*":
                        number.Push(second * first);
                        break;
                    case "/":
                        number.Push(second / first);
                        break;
                }
            } else {
                number.Push(int.Parse(token));
            }
        }
        return number.Peek();
    }
}
