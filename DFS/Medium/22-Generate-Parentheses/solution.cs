public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        // dfs + backtracking
        // tc:O(n!); sc:O(n)
        if(n <= 0) {
            return new List<string>();
        }
        IList<string> res = new List<string>();
        StringBuilder path = new StringBuilder();
        AddParenthesis(res, path, n, 0, 0);
        return res;
    }
    
    private void AddParenthesis(IList<string> res, StringBuilder path, int n, int leftCnt, int rightCnt) {
        if(leftCnt == n && rightCnt == n) {
            res.Add(path.ToString());
            return;
        }
        if(leftCnt < n) {
            path.Append('(');
            AddParenthesis(res, path, n, leftCnt + 1, rightCnt);
            path.Length--; // backtracking
        }
        if(rightCnt < leftCnt) {
            path.Append(')');
            AddParenthesis(res, path, n, leftCnt, rightCnt + 1);
            path.Length--;  // backtracking
        }        
    }
}