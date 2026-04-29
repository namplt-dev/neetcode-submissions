public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();

        foreach (int i in nums) {
            dic[i] = dic.GetValueOrDefault(i, 0) + 1;
        }
        var result = new int[k];
        var resDic = dic.OrderBy(x => x.Value).TakeLast(k);
        var indexRes = 0;
        foreach (var r in resDic) {
            result[indexRes] = r.Key;
            indexRes++;
        }
        return result;
    }
}
