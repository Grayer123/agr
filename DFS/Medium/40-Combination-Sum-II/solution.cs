public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        // dfs + backtracking
        // tc:O(2^n * n); sc:O(n)
        if(candidates == null || candidates.Length == 0 || target <= 0) {
            return new List<IList<int>>();
        }
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        Array.Sort(candidates);
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
            if(i > 0 && candidates[i] == candidates[i - 1] && i != pos) { // skip duplicates: if the duplicate before current not picked => not pick current 
                continue;
            }
            sum += candidates[i];
            path.Add(candidates[i]);
            FindCombinations(candidates, res, path, ref sum, i + 1, target); // pass i as pos => not going back
            sum -= candidates[i];  // backtracking
            path.RemoveAt(path.Count - 1);  // backtracking
        }
    }
}