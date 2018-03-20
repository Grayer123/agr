public class Solution {
    public string ReverseWords(string s) {
        // split()
        //TC:O(n); SC:O(n)
        if(String.IsNullOrWhiteSpace(s)){
            return string.Empty;
        }       
        string[] arr = s.Trim().Split(' '); //remove leading and trailing zeros first
        StringBuilder builder = new StringBuilder(); 
        for(int i = arr.Length - 1; i >= 0; i--){
            if(String.IsNullOrWhiteSpace(arr[i])){
                continue;
            }
            builder.Append(arr[i]).Append(" ");
        }
        return builder.ToString().Trim();
    }
}