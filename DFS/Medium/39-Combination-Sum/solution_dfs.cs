public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        // dfs; backtracking
        // tc:O(2^n * n); sc:O(n)
        if(candidates == null || candidates.Length == 0 || target <= 0) {
            return new List<IList<int>>();
        }
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        int sum = 0;
        FindCombinations(candidates, res, path, ref sum, 0, target);
        return res;
    }
    
    private void FindCombinations(int[] candidates, IList<IList<int>> res, List<int> path, ref int sum, int pos, int target) {
        if(sum >= target || pos >= candidates.Length) {
            if(sum == target) {
                res.Add(new List<int>(path));
            }
            return;
        }
        for(int i = pos; i < candidates.Length; i++) {
            sum += candidates[i];
            path.Add(candidates[i]);
            FindCombinations(candidates, res, path, ref sum, i, target); // pass i as pos => not going back
            sum -= candidates[i];  // backtracking
            path.RemoveAt(path.Count - 1);  // backtracking
        }
        
        // foreach(int num in candidates) { // duplicates combination [1,2], [2,1] not allowed => need to pass pos to maintain order
        //     sum += num;
        //     path.Add(num);
        //     FindCombinations(candidates, res, path, ref sum, target);
        //     sum -= num; // backtracking
        //     path.RemoveAt(path.Count - 1); // backtracking
        // }
    }
}