public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        var dict = new Dictionary<string, List<string>>();
        foreach (string str in strs) {
            var sortedStr = string.Concat(str.OrderBy(c => c));
            if (!dict.ContainsKey(sortedStr)) {
                dict[sortedStr] = new List<string>();
            }
            dict[sortedStr].Add(str);
        }
        dict.OrderBy(c => c.Value.Count);
        foreach (var dic in dict) {
            result.Add(dic.Value);
        }
        return result;
    }
}
