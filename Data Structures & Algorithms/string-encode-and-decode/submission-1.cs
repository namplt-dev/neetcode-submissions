public class Solution {
    public string Encode(IList<string> strs) {
        var result = "";
        foreach (string str in strs) {
            result += $"{str.Length}#{str}";
        }
        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            var strLength = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            j = i + strLength;
            result.Add(s.Substring(i, strLength));
            i = j;
        }
        return result;
    }
}
