public class Solution {
    public int RomanToInt(string s) {
        // string + math + array as hashTable
        // tc:O(n); sc:O(n)
        if(string.IsNullOrEmpty(s)) {
            return 0;
        }
        int[] dict = new int[128];
        dict['M'] = 1000;
        dict['D'] = 500;
        dict['C'] = 100;
        dict['L'] = 50;
        dict['X'] = 10;
        dict['V'] = 5;
        dict['I'] = 1;
        
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