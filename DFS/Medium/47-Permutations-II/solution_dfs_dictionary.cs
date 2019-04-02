public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        // dfs: backtracking 
        // tc:O(n!); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return new List<IList<int>>();
        }
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int num in nums) {
            dict[num] = dict.ContainsKey(num) ? ++dict[num] : 1;
        }
        List<int> keySet = dict.Keys.ToList(); // if direct change and traverse dict same time => exeception: collection modified
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> path = new List<int>();
        FindPermutation(dict, res, path, keySet, nums.Length);
        return res;
    }
    private void FindPermutation(Dictionary<int, int> dict, IList<IList<int>> res, IList<int> path, List<int> keySet, int len) {
        if(path.Count == len) {
            res.Add(new List<int>(path)); // deep copy
            return;
        }
        foreach(int key in keySet) { // if access dict.Keys: collection was modified, enumeration op may not execute
            if(dict[key] <= 0) {
                continue;
            }
            path.Add(key);
            dict[key]--;
            FindPermutation(dict, res, path, keySet, len);
            path.RemoveAt(path.Count - 1); // backtracking
            dict[key]++;
        }
    }
}