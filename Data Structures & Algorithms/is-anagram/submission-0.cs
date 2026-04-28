public class Solution {
    public bool IsAnagram(string s, string t) {
        var hashS = new Dictionary<char, int>();
        var hashT = new Dictionary<char, int>();
        foreach (var c in s) {
            if (!hashS.ContainsKey(c)) {
                hashS[c] = 0;
            }
            hashS[c]++;
        }
        foreach (var c in t) {
            if (!hashT.ContainsKey(c)) {
                hashT[c] = 0;
            }
            hashT[c]++;
        }
        if (hashS.Count != hashT.Count) {
            return false;
        }
        foreach (var c in hashS) {
            if (!hashT.ContainsKey(c.Key) || hashT[c.Key] != c.Value) {
                return false;
            }
        }
        return true;
    }
}
