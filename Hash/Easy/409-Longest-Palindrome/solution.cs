public class Solution {
    public int LongestPalindrome(string s) {
        // hash table
        //TC:O(n); SC:O(n)
        if(s == null || s.Length == 0){ //corner case
            return 0;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char c in s){
            if(!dict.ContainsKey(c)){
                dict[c] = 1;
            }
            else{
                dict[c]++;
            }
        }
        bool isOdd = false;
        int res = 0;
        foreach(var val in dict.Values){
            if(val % 2 != 0){
                isOdd = true;
                res += (val - 1);
            }
            else{
                res += val;
            }
        }
        return isOdd ? res + 1 : res;
    }
}