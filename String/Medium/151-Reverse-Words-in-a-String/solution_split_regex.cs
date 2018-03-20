using System.Text.RegularExpressions;
public class Solution {
    public string ReverseWords(string s) {
        // reverse two times
        //TC:O(n); SC:O(n)
        if(String.IsNullOrWhiteSpace(s)){
            return string.Empty;
        }
        string[] arr = Regex.Split(s.Trim(), @"\s+");
        Array.Reverse(arr);
        return String.Join(" ", arr);
    }
}