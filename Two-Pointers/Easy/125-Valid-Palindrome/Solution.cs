public class Solution {
    public bool IsPalindrome(string s) {
        // two pointers
        // TC:O(n); SC:O(1)
        if(s == null || s.Length <= 1) {
            return true;
        }
        int start = 0, end = s.Length - 1;
        while(start < end) {
            while(start < end && !char.IsLetterOrDigit(s[start])) {
                start++;
            }
            
            while(end > start && !char.IsLetterOrDigit(s[end])) {
                end--;
            }
            if(start == end) {
                return true;
            }
            if(Char.ToLower(s[start]) != Char.ToLower(s[end])) {
                return false;
            }
            start++;
            end--;
        }
        return start >= end;          
    }
}