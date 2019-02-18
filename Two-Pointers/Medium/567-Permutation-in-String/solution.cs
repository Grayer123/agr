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
             
        while(right < s2.Length) {
            if(!dictS1.ContainsKey(s2[right])) { // no matching char, window start set to next char
                right++;
                left = right;
                windowCounts.Clear();
            }
            else {
                windowCounts[s2[right]] = windowCounts.ContainsKey(s2[right]) ? ++windowCounts[s2[right]] : 1;
                if(right - left + 1 == s1.Length) {
                    if(CompareHashTable(dictS1, windowCounts)) {
                        return true;
                    }
                    windowCounts[s2[left]]--;
                    left++;
                }
                right++;
            }
            
        }
        return false;
    }
    
    private bool CompareHashTable(Dictionary<char, int> d1, Dictionary<char, int> d2) {
        foreach(var key in d1.Keys) {
            if(!d2.ContainsKey(key) || d2[key] != d1[key]) {
                return false;
            }           
        }
        return true;
    }
}