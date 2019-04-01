public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        // dfs: backtracking 
        // tc:O(n!); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return new List<IList<int>>();
        }
        HashSet<int> hash = new HashSet<int>();
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> path = new List<int>();
        FindPermutation(nums, res, path, hash);
        return res;
    }
    private void FindPermutation(int[] nums, IList<IList<int>> res, IList<int> path, HashSet<int> hash) {
        if(path.Count == nums.Length) {
            res.Add(new List<int>(path)); // deep copy
            return;
        }
        foreach(int num in nums) {
            if(hash.Contains(num)) {
                continue;
            }
            hash.Add(num);
            path.Add(num);
            FindPermutation(nums, res, path, hash);
            path.RemoveAt(path.Count - 1); // backtracking
            hash.Remove(num);
        }
    }
}