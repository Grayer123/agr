public class Solution {
    public string ReverseWords(string s) {
        // reverse two times
        //TC:O(n); SC:O(1) => not counting the ToCharArray part
        if(String.IsNullOrWhiteSpace(s)){
            return string.Empty;
        }
        char[] charArr = s.Trim().ToCharArray(); //remove leading and trailing zeros first
        int count = 0;
        for(int i = 0; i < charArr.Length; i++){ //reverse each word in the charArr
            if(charArr[i] != ' '){
                count++;
            }
            else{
                Array.Reverse(charArr, i - count, count);
                count = 0;
            }
        }
        Array.Reverse(charArr, charArr.Length - count, count); //reverse the last portion
        
        int idx = 0;  //keep record of the valid portion => (word + only one ' ')
        bool flag = false;
        for(int i = 0; i < charArr.Length; i++){
            if(charArr[i] != ' '){
                charArr[idx++] = charArr[i];
                flag = false;
            }
            else{
                if(!flag){
                    charArr[idx++] = charArr[i];
                    flag = true;
                }
            }
        }
        Array.Reverse(charArr, 0, idx);  //only reverse the valid portion
        return new string(charArr, 0, idx); //just return the valid portion
    }
}