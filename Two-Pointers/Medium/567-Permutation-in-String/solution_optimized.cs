public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // sliding window + hash table
        // tc:O(n); sc:O(n)
        if(s1.Length > s2.Length) {
            return false;
        }
        Dictionary<char, int> dictS1 = new Dictionary<char, int>();
        foreach(char c in s1) {
            dictS1[c] = dictS1.ContainsKey(c) ? ++dictS1[c] : 1;
        }
        
        Dictionary<char, int> windowCounts = new Dictionary<char, int>();
        int left = 0, right = 0;
        int matched = 0;
             
        while(right < s2.Length) {
            if(!dictS1.ContainsKey(s2[right])) {
                right++;
                left = right;
                windowCounts.Clear();
                matched = 0;
            }
            else {
                windowCounts[s2[right]] = windowCounts.ContainsKey(s2[right]) ? ++windowCounts[s2[right]] : 1;
                if(windowCounts[s2[right]] == dictS1[s2[right]]) {
                    matched++;
                }
                else if(windowCounts[s2[right]] == dictS1[s2[right]] + 1) {
                    matched--;
                }
                if(right - left + 1 == s1.Length) {
                    if(matched == dictS1.Count) {
                        return true;
                    }
                    windowCounts[s2[left]]--;
                    if(windowCounts[s2[left]] == dictS1[s2[left]]) {
                    matched++;
                }
                else if(windowCounts[s2[left]] == dictS1[s2[left]] - 1) {
                    matched--;
                }
                    left++;
                }
                right++;
            }
            
        }
        return false;
    }
}