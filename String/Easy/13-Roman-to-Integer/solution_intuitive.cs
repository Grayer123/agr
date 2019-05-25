public class Solution {
    public int RomanToInt(string s) {
        // string + math
        // tc:O(n); sc:O(n)
        if(string.IsNullOrEmpty(s)) {
            return 0;
        }
        int[] digits = new int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string[] romes = new string[] {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for(int i = 0; i < romes.Length; i++) {
            dict[romes[i]] = digits[i];
        }
        int res = 0;
        int pos = 0;
        while(pos < s.Length) {
            if(pos + 1 < s.Length) {
                string sub = s.Substring(pos, 2);
                if(dict.ContainsKey(sub)) {
                    res += dict[sub];
                    pos += 2;
                    continue;
                }
            }
            res += dict[s[pos].ToString()];
            pos++;
        }
        return res;
    }
}