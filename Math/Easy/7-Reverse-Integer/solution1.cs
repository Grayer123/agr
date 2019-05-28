public class Solution {
    public int Reverse(int x) {
        // math
        // tc:O(n); sc:O(1)
        if(x == 0 || x == Int32.MinValue) { // no conversion or overflow
            return 0;
        }
        int sign = x > 0 ? 1 : -1;
        int res = 0;
        x *= sign;
        while(x > 0) {
            int digit = x % 10;
            x /= 10;
            if(res > Int32.MaxValue / 10 || res == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10) { // overflow
                return 0; 
            }
            res = res * 10 + digit;
        } 
        return res * sign;
    }
}