public class Solution {
    public string IntToRoman(int num) {
        // string + math
        // tc:O(n); sc:O(n)
        if(num < 1 || num > 3999) {
            return string.Empty;
        }
        string[] romes = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
	    int[] digits = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        StringBuilder str = new StringBuilder();
        int size = romes.Length, idx = 0;
        while(num > 0 && idx < size) {
            if(num >= digits[idx]) {
                int count = num / digits[idx];
                num %= digits[idx];
                for(int i = 0; i < count; i++) {
                    str.Append(romes[idx]);
                }
            }
            idx++;
        }        
        return str.ToString();
    }
}