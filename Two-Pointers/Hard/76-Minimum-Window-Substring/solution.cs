public class Solution {
    public string MinWindow(string s, string t) {
        // two pointers(sliding window); hash table
        //TC:O(n); SC:O(n)
        if(s.Length < t.Length || s.Length == 0 || t.Length == 0) {
            return String.Empty;
        }
        Dictionary<char, int> dictT = new Dictionary<char, int>(); 
        foreach(char c in t) { //store t unique character and appearances in dictT
            dictT[c] = dictT.ContainsKey(c) ? ++dictT[c] : 1;
        }
        int left = 0, right = 0;
        int numOfMatched = 0;
        int[] res = {-1, -1};
        Dictionary<char, int> windowCounts = new Dictionary<char, int>();
        while(right < s.Length) {
            while(right < s.Length) { // find the window
                if(dictT.ContainsKey(s[right])) {
                    windowCounts[s[right]] = windowCounts.ContainsKey(s[right]) ? ++windowCounts[s[right]] : 1;
                    if(dictT[s[right]] == windowCounts[s[right]]) {
                        numOfMatched++;
                    }
                    if(numOfMatched == dictT.Count) {
                        break;
                    }
                }
                right++;
            }
            if(right >= s.Length) {
                break;
            }
            while(numOfMatched == dictT.Count && left <= right - t.Length + 1) { // contract the window
                if(dictT.ContainsKey(s[left])) {
                    windowCounts[s[left]]--;
                    if(windowCounts[s[left]] < dictT[s[left]]) {
                        numOfMatched--;
                    }
                }
                left++;
            }
            if(res[0] == - 1 || res[1] - res[0] > right - left) {
                res[0] = left - 1;
                res[1] = right;
            }
            right++;
        }
        if(res[0] == -1) {
            return String.Empty;
        }
        return s.Substring(res[0], res[1] - res[0] + 1);
    }
}