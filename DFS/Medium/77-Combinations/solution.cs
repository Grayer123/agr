public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        // dfs + backtracking
        // tc:O(); sc:O(n)
        if(n <= 0 || k <= 0) {
            return new List<IList<int>>();
        }
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        FindCombination(res, path, n, k, 1);
        return res;
    }
    
    private void FindCombination(IList<IList<int>> res, List<int> path, int n, int k, int pos) {
        if(path.Count == k) {
            res.Add(new List<int>(path));
            return;
        }
        for(int i = pos; i <= n; i++) {
            path.Add(i);
            FindCombination(res, path, n, k, i + 1);
            path.RemoveAt(path.Count - 1); // backtracking
        }
    }
}