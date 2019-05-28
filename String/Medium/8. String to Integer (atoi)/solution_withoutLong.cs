public class Solution {
    public int MyAtoi(string str) {
        // string + math + without using long
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(str)) {
            return 0;
        }
        int pos = 0, sign = 1;
        int res = 0;
        // str = str.Trim();
        while(pos < str.Length && str[pos] == ' ') { // skip the leading white space
            pos++;
        }
        if(pos == str.Length || str[pos] != '+' && str[pos] != '-' && !Char.IsDigit(str[pos])) { // no conversion to perform
            return 0;
        }
        if(str[pos] == '+') { // sign bit
            pos++;
        }
        else if(str[pos] == '-') {
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