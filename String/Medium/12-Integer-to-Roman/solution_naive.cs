public class Solution {
    public string IntToRoman(int num) {
        // string + math
        // tc:O(); sc:O()
        if(num < 1 || num > 3999) {
            return string.Empty;
        }
        StringBuilder str = new StringBuilder();
        int count = 0;
        while(num > 0) {
            if(num >= 1000) {
                count = num / 1000;
                num = num % 1000;
                for(int i = 0; i < count; i++) {
                    str.Append("M");
                }
            }
            else if(num >= 900) {
                num -= 900;
                str.Append("CM");
            }
            else if(num >= 500) {
                num -= 500;
                str.Append("D");
            }
            else if(num >= 400) {
                num -= 400;
                str.Append("CD");
            }
            else if(num >= 100) {
                count = num / 100;
                num = num % 100;
                for(int i = 0; i < count; i++) {
                    str.Append("C");
                }
            }
            else if(num >= 90) {
                num -= 90;
                str.Append("XC");
            }
            else if(num >= 50) {
                num -= 50;
                str.Append("L");
            }
            else if(num >= 40) {
                num -= 40;
                str.Append("XL");
            }
            else if(num >= 10) {
                count = num / 10;
                num = num % 10;
                for(int i = 0; i < count; i++) {
                    str.Append("X");
                }
            }
            else if(num >= 9) {
                num -= 9;
                str.Append("IX");
            }
            else if(num >= 5) {
                num -= 5;
                str.Append("V");
            }
            else if(num >= 4) {
                num -= 4;
                str.Append("IV");
            }
            else if(num >= 1) {
                count = num;
                num = 0;
                for(int i = 0; i < count; i++) {
                    str.Append("I");
                }
            }
        }
        return str.ToString();
    }
}