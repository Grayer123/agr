public class Solution {
    public bool IsSubsequence(string s, string t) {
        //two pointers
        //tc:O(n); sc:O(1)
        if(t.Length < s.Length){ //corner case
            return false;
        }
        if(string.IsNullOrEmpty(s)){
            return true;
        }
        int idx = 0;
        for(int i = 0; i < t.Length; i++){
            if(t[i] == s[idx]){
                idx++;
                if(idx == s.Length){
                    return true;
                }
            }
        }
        return false;
    }
}