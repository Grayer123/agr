public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        // backtracking
        // tc:O(2^n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return new List<IList<int>> {new List<int>()};
        }
        
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        HashSet<int> hash = new HashSet<int>();
        FindSubsets(nums, res, path, 0);
        return res;

    }
    private void FindSubsets(int[] nums, IList<IList<int>> res, List<int> path, int pos) {
        res.Add(new List<int>(path));
        for(int i = pos; i < nums.Length; i++) {
            path.Add(nums[i]);
            FindSubsets(nums, res, path, i + 1); // here i + 1 not pos + 1
            path.RemoveAt(path.Count - 1);
        }
    }
}