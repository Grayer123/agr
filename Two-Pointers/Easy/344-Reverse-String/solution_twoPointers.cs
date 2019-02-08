public class Solution {
    public void ReverseString(char[] s) {
        // two opposite pointers
        // tc:O(n);sc:O(1)
        if(s == null || s.Length < 2) {
            return;
        }
        int left = 0, right = s.Length - 1;
        while(left < right) {
            char tmp = s[left];
            s[left] = s[right];
            s[right] = tmp;
            left++;
            right--;
        }
    }
}