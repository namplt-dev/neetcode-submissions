public class Solution {
        public string Encode(IList<string> strs)
        {
            var result = "";
            foreach (string str in strs)
            {
                result += $"{str.Length}#{str}";
            }
            return result;
        }

        public List<string> Decode(string s)
        {
            var result = new List<string>();
            var strLength = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    strLength = string.Concat(strLength, s[i]);
                }
                if (s[i] == '#')
                {
                    var takeLenght = int.Parse(strLength);
                    result.Add(s.Substring(++i, takeLenght));
                    strLength = string.Empty;
                    i += takeLenght - 1;
                }
            }
            return result;
        }
}
