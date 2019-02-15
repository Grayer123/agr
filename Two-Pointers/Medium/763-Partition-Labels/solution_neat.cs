public class Solution {
    public IList<int> PartitionLabels(string s) {
        // two same directional pointers; hash table
        // tc:O(n); sc:O(1)
        if(s == null || s == string.Empty) {
            return new List<int>();
        }
        int[] arr = new int[26]; // only lowercase letter
        IList<int> res = new List<int>();
        for(int i = 0; i < s.Length; i++) {
            arr[s[i] - 'a'] = i;
        }
        int left = 0, right = 0;
        for(int i = 0; i < s.Length; i++) {
            right = Math.Max(arr[s[i] - 'a'], right);
            if(i == right) {
                res.Add(right - left + 1);
                left = right + 1; // pointer to the start of next partition
            }
        }
        return res;
    }
}