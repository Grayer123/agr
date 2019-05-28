public class Solution {
    public int MyAtoi(string str) {
        // string + math + using long
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(str)) {
            return 0;
        }
        str = str.Trim(); // remove leading and trailing white space
        int pos = 0, sign = 1;
        long res = 0;
        if(str == "" || str[0] != '+' && str[0] != '-' && !Char.IsDigit(str[0])) { // no conversion to perform
            return 0;
        }
        if(str[0] == '+') {
            pos++;
        }
        else if(str[0] == '-') {
            sign = -1;
            pos++;
        }
       
        while(pos < str.Length && Char.IsDigit(str[pos])) {
            res = res * 10 + (str[pos] - '0') * sign;
            pos++;
            if(sign == 1 && res >= Int32.MaxValue) {
                return Int32.MaxValue;
            } 
            else if(sign == -1 && res <= Int32.MinValue) {
                return Int32.MinValue;
            }
        }
        return (int)res;
    }
}