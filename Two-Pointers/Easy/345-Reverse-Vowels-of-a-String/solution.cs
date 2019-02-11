public class Solution {
    public string ReverseVowels(string s) {
        // two opposite pointers
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(s)) {
            return s;
        }
        int left = 0, right = s.Length - 1;
        char[] arr = s.ToArray();
        while(left < right) {
            while(left < right && !isVowel(s[left])) {
                left++;
            }
            while(left < right && !isVowel(s[right])) {
                right--;
            }
            if(left < right) {
                char tmp = arr[left];
                arr[left] = arr[right];
                arr[right] = tmp;
                left++;
                right--;
            }
        }
        return new string(arr);
        
    }
    
    private bool isVowel(char c) {
        c = Char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}