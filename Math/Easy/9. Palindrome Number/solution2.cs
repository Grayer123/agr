public class Solution {
    public bool IsPalindrome(int x) {
        // math
        // tc:O(log10(n)); sc:O(1)
        if(x < 0 || x % 10 == 0 && x != 0) {  // corner case: negative num || for num with last digit of 0 
            return false;
        }
        int reversed = 0;
        while(x > reversed) {  // guarantee to reach at least half of the digits 
            int lastDigit = x % 10;
            reversed = reversed * 10 + lastDigit;
            x /= 10;
        }
        if(x < reversed) { // eg: 121
            x = x * 10 + reversed % 10;
        }
        return x == reversed;
    }
}