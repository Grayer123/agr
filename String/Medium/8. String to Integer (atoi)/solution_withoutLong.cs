public class Solution {
    public int MyAtoi(string str) {
        // string + math + without using long
        // tc:O(n); sc:O(1)
        if(String.IsNullOrEmpty(str)) {
            return 0;
        }
        str = str.Trim(); // remove leading and trailing white space
        int pos = 0, sign = 1;
        int res = 0;
        if(str == "" || str[0] != '+' && str[0] != '-' && !Char.IsDigit(str[0])) { // no conversion to perform
            return 0;
        }
        if(str[0] == '+') { // sign bit
            pos++;
        }
        else if(str[0] == '-') {
            sign = -1;
            pos++;
        }
       
        while(pos < str.Length && Char.IsDigit(str[pos])) {
            if(res > Int32.MaxValue / 10 || res == Int32.MaxValue / 10 && str[pos] - '0' > Int32.MaxValue % 10) { // overflow scenario
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }        
            res = res * 10 + str[pos] - '0';
            pos++;
        }
        return res * sign;  // return result with sign bit
    }
}