public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Stack<double> stack = new Stack<double>();
        Dictionary<int, int> sV = new Dictionary<int, int>();

        for (int i = 0; i < position.Length; i++) {
            sV.Add(position[i], speed[i]);
        }
        IOrderedEnumerable<KeyValuePair<int, int>> sorted = sV.OrderByDescending(x => x.Key);

        foreach (var sv in sorted) {
            double time = (double)(target - sv.Key) / sv.Value;
            if (stack.Count > 0 && time <= stack.Peek()) {
                continue;
            } else {
                stack.Push(time);
            }
        }
        return stack.Count;
    }
}
