public class Solution {
    public bool IsSubsequence(string s, string t) {
        //Follow up: two pointers; binary search
        //tc:O(n + m * logx); sc:O(x)
        if(String.IsNullOrEmpty(s)){//corner case
            return true;
        }
        if(t.Length < s.Length){//corner case
            return false;
        }
        List<int>[] dictT = new List<int>[26];
        for(int i = 0; i < t.Length; i++){ //iterate t to get a similar dictionary of t
            int idx = t[i] - 'a';
            if(dictT[idx] == null){
                dictT[idx] = new List<int>();
            }
            dictT[idx].Add(i);
        }
        
        int idxCurChar = 0;
        foreach(char c in s){
            int idx = c - 'a';
            if(dictT[idx] == null){
                return false;
            }
            int index = dictT[idx].BinarySearch(idxCurChar);
            index = index >= 0 ? index : ~index;
            if(index == dictT[idx].Count){
                return false;
            }
            idxCurChar = dictT[idx][index] + 1;
        }
        return true;
    }
}