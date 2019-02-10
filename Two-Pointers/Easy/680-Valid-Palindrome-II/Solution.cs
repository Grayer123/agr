public class Solution {
    public bool ValidPalindrome(string s) {
        // two pointers
        // TC:O(n); SC:O(1)
        if(s == null || s.Length <= 2) {
            return true;
        }
        int start = 0, end = s.Length - 1;
        while(start < end) {
           if(s[start] != s[end]) {
            //    var leftVal = start + 1 <= end ? s[start + 1] : s[start];
            //    var rightVal = end - 1 >= start ? s[end - 1] : s[end];
            //    string leftStr = s[start] == rightVal ? s.Substring(start, end - start) : String.Empty;
            //    string rightStr = s[end] == leftVal ? s.Substring(start + 1, end - start) : String.Empty;
            //    return isPalindrome(leftStr) || isPalindrome(rightStr);
                return isPalindrome(s.Substring(start, end - start)) || isPalindrome(s.Substring(start + 1, end - start));
           }
            start++;
            end--;
        }
        return true;
    }
    
    public bool isPalindrome(string s) {
        if(s.Length == 0) {
            return false;
        }
        int start = 0, end = s.Length - 1;
        while(start < end) {
            if(s[start] != s[end]) {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}