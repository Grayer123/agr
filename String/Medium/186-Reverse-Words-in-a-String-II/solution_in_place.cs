public class Solution {
    public void ReverseWords(char[] str) {
        // reverse two times
        //TC:O(n); SC:O(1) 
        if(str == null || str.Length == 0){ //corner case
            return;
        }
         int count = 0;
        for(int i = 0; i < str.Length; i++){ //reverse each word in the str
            if(str[i] != ' '){
                count++;
            }
            else{
                Array.Reverse(str, i - count, count);
                count = 0;
            }
        }
        Array.Reverse(str, str.Length - count, count); //reverse the last portion
        Array.Reverse(str);  //reverse the whole string
    }
}