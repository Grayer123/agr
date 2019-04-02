public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        // dfs: backtracking + sort
        // tc:O(2^n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return new List<IList<int>>();
        }
        Array.Sort(nums); // sort the array, so that duplicates align together
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> path = new List<int>();
        bool[] visited = new bool[nums.Length];
        FindPermutation(nums, visited, res, path);
        return res;
    }
    
    private void FindPermutation(int[] nums, bool[] visited, IList<IList<int>> res, IList<int> path) {
        if(path.Count == nums.Length) {
            res.Add(new List<int>(path)); // deep copy
            return;
        }
        for(int i = 0; i < nums.Length; i++) {
            if(visited[i]) { // has been add the path
                continue;
            }
            if(i > 0 && nums[i] == nums[i - 1] && !visited[i - 1]) { // for duplicates, if previous not in path, cur not in also
                continue;
            }
            path.Add(nums[i]);
            visited[i] = true;
            FindPermutation(nums, visited, res, path);
            path.RemoveAt(path.Count - 1);
            visited[i] = false;
            
        }
    }
}