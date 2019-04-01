public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        // dfs: backtracking 
        // tc:O(n!); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return new List<IList<int>>();
        }
        bool[] visited = new bool[nums.Length];
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> path = new List<int>();
        FindPermutation(nums, res, path, visited);
        return res;
    }
    private void FindPermutation(int[] nums, IList<IList<int>> res, IList<int> path, bool[] visited) {
        if(path.Count == nums.Length) {
            res.Add(new List<int>(path)); // deep copy
            return;
        }
        for(int i = 0; i < nums.Length; i++) {
            if(visited[i]) {
                continue;
            }
            visited[i] = true;
            path.Add(nums[i]);
            FindPermutation(nums, res, path, visited);
            path.RemoveAt(path.Count - 1); // backtracking
            visited[i] = false;
        }
    }
}