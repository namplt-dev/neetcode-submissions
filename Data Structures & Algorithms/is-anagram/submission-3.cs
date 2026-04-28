public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var dicS = new Dictionary<char, int>();
        var dicT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            dicS[s[i]] = dicS.GetValueOrDefault(s[i], 0) + 1;
            dicT[t[i]] = dicT.GetValueOrDefault(t[i], 0) + 1;
        }
        return dicS.Count == dicT.Count && !dicS.Except(dicT).Any();
    }
}
