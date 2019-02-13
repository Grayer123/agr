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
        int left = 0, right = 0; // two pointers
        int numOfMatched = 0; // how many unique chars in s matched in t (matched means if 'a' appears 2 times in t, also 2 times in s)
        int[] res = {-1, -1}; // record the startIndex, endIndex of smallest window
        Dictionary<char, int> windowCounts = new Dictionary<char, int>(); // store unique chars (appeared in t) and its times of appearance

        while(right < s.Length) {
            if(dictT.ContainsKey(s[right])) { // if num appears in dictT
                windowCounts[s[right]] = windowCounts.ContainsKey(s[right]) ? ++windowCounts[s[right]] : 1; // add in windowCounts as well
                if(dictT[s[right]] == windowCounts[s[right]]) { // s[right] is fully matched in s and t (both char itself and appearances)
                    numOfMatched++;
                }
            }
            while(numOfMatched == dictT.Count && left <= right - t.Length + 1) { // a sliding window has been found
                if(dictT.ContainsKey(s[left])) { // s[left] in dictT
                    windowCounts[s[left]]--;
                    if(windowCounts[s[left]] < dictT[s[left]]) { // s[left] not matched in s and t anymore
                        numOfMatched--;  // cannot contract further => loop break => try to extend right to find new matched window
                    }
                }
                left++;  // contract window size
            }
            if(res[0] == - 1 || res[1] - res[0] > right - left) { // update the index of minimum sliding window
                res[0] = left - 1;
                res[1] = right;
            }
            right++;
        }
        return res[0] == -1 ? String.Empty : s.Substring(res[0], res[1] - res[0] + 1); // caution about no solution available case
    }
}