//using System.Text;
public class Solution {
    public string ReverseWords(string s) {
        // reverse two times
        //TC:O(n); SC:O(n)
        if(String.IsNullOrWhiteSpace(s)){
            return string.Empty;
        }
        s.Trim(); //remove leading and trailing zeros
        string[] arr = s.Split(' ');
        StringBuilder builder = new StringBuilder(); 
        foreach(string str in arr){
            if(String.IsNullOrWhiteSpace(str)){
                continue;
            }
            builder.Append(ReverseString(str)).Append(" ");
        }
        return ReverseString(builder.ToString().Trim());
    }
    private string ReverseString(string s){
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}