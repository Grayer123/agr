public class Solution {
    public int TotalFruit(int[] tree) {
        // two pointers: max sliding window
        // TC:O(n); DC:O(n)
        if(tree == null || tree.Length == 0) {
            return 0;
        }
        int left = 0, right = 0;
        int maxLen = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        while(right < tree.Length) {
            dict[tree[right]] = dict.ContainsKey(tree[right]) ? ++dict[tree[right]] : 1;
            if(dict.Count == 3) {
                maxLen = Math.Max(maxLen, right - left);
                while(dict.Count > 2 && left <= right) {
                    dict[tree[left]]--;
                    if(dict[tree[left]] == 0) {
                        dict.Remove(tree[left]);
                    }
                    left++;
                }
            }
            right++;
        }
        return Math.Max(maxLen, right - left);
    }
}