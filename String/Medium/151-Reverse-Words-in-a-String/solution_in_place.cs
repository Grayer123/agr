public class Solution {
    public string ReverseWords(string s) {
        // reverse two times, not using any string manipulation default function
        //TC:O(n); SC:O(1) => not counting the ToCharArray part
        if(String.IsNullOrWhiteSpace(s)){
            return string.Empty;
        }
        char[] charArr = s.ToCharArray(); 
        Array.Reverse(charArr);  // reverse the whole sentence
        ReverseWords(charArr); // reverse each word in the sentence
        return RemoveSpaces(charArr); // remove leading, trailing, and multiple spaces
    }
    
    private void ReverseWords(char[] charArr) {
        int pos = 0;
        while(pos < charArr.Length) {
            if(charArr[pos] == ' ') {
                pos++;
                continue;
            }
            int startIdx = pos;
            while(pos < charArr.Length && charArr[pos] != ' ') {
                pos++;
            }
            Array.Reverse(charArr, startIdx, pos - startIdx);
        }
    }
    
    private string RemoveSpaces(char[] charArr) {
        int startIdx = 0, pos = 0;
        while(pos < charArr.Length) {
            while(pos < charArr.Length && charArr[pos] == ' ') { // remove leading space
                pos++; 
            }
            while(pos < charArr.Length && charArr[pos] != ' ') {
                charArr[startIdx++] = charArr[pos++];
            }
            if(pos < charArr.Length) {
                charArr[startIdx++] = ' '; // adding one space between words
            }
        }
        if(startIdx > 0 && charArr[startIdx - 1] == ' ') { // check whether last char is ' '
            startIdx--;
        }
        return new String(charArr, 0, startIdx);
    }
}