public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        // backtracking
        // tc:O(2^n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return new List<IList<int>> { new List<int>() }; // corner case
        }
        Array.Sort(nums); // duplicate nums aligns together
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        FindSubsets(nums, res, path, 0);
        return res;
    }
    
    private void FindSubsets(int[] nums, IList<IList<int>> res, List<int> path, int pos) {
        res.Add(new List<int>(path));
        for(int i = pos; i < nums.Length; i++) {
            if(i != 0 && i != pos && nums[i - 1] == nums[i]) { // skip duplicates
                continue;
            }
            path.Add(nums[i]);
            FindSubsets(nums, res, path, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}