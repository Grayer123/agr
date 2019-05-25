public class Solution {
    public int RomanToInt(string s) {
        // string + math + hashTable
        // tc:O(n); sc:O(n)
        if(string.IsNullOrEmpty(s)) {
            return 0;
        }
        Dictionary<char, int> dict = new Dictionary<char, int> {
            {'M', 1000}, {'D', 500}, {'C', 100}, {'L', 50}, {'X', 10}, {'V', 5}, {'I', 1}};
        
        int res = 0;
        int pos = 0;
        while(pos < s.Length) {
            if(pos + 1 < s.Length && dict[s[pos]] < dict[s[pos + 1]]) {
                res += (dict[s[pos + 1]] - dict[s[pos]]);
                pos += 2;
            }
            else {
                res += dict[s[pos]];
                pos++;
            }
        }
        return res;
    }
}