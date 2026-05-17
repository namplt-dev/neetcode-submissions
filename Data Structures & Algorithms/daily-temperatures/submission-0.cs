public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] res = new int[len];
        Array.Fill(res, 0);

        int idx = 0;
        for (int i = 0; i < len - 1; i++) {
            for (int j = i + 1; j < len; j++) {
                if (temperatures[j] > temperatures[i]) {
                    res[idx] = j - i;
                    break;
                }
            }
            idx++;
        }
        return res;
    }
}
