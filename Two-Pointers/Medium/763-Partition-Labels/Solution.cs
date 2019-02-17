public class Solution {
    public IList<int> PartitionLabels(string s) {
        // two same directional pointers; hash table
        // tc:O(n); sc:O(n)
        if(s == null || s == string.Empty) {
            return new List<int>();
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        IList<int> res = new List<int>();
        for(int i = 0; i < s.Length; i++) {
            dict[s[i]] = i;
        }
        int left = 0, right = 0;
        int cur = 0;
        while(left < s.Length) {
            while(left <= right){
                right = Math.Max(dict[s[left]], right);
                left++;
            }
            res.Add(left - cur);
            cur = left;
            right = left;
        }
        return res;
    }
}
