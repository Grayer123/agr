public class Solution {
    public int StrStr(string haystack, string needle) {
        //tc:O(m*n); sc:O(1)
        if(string.IsNullOrEmpty(needle)){ //corner case
            return 0; 
        }
        if(string.IsNullOrEmpty(haystack)){
            return -1; //corner case
        }
        int len1 = haystack.Length, len2 = needle.Length;
        for(int i = 0; i <= len1 - len2; i++){
            if(haystack[i] == needle[0]){
                int j, k = i + 1; //get a copy of i
                for(j = 1; j < len2; j++){
                    if(haystack[k++] != needle[j]){
                        break;
                    }
                }
                if(j == len2){
                    return i;
                }
            } 
        }
        return -1;
    }
}