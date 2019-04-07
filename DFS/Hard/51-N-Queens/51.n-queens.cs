/*
 * @lc app=leetcode id=51 lang=csharp
 *
 * [51] N-Queens
 *
 * https://leetcode.com/problems/n-queens/description/
 *
 * algorithms
 * Hard (38.13%)
 * Total Accepted:    134.3K
 * Total Submissions: 350.2K
 * Testcase Example:  '4'
 *
 * The n-queens puzzle is the problem of placing n queens on an n×n chessboard
 * such that no two queens attack each other.
 * 
 * 
 * 
 * Given an integer n, return all distinct solutions to the n-queens puzzle.
 * 
 * Each solution contains a distinct board configuration of the n-queens'
 * placement, where 'Q' and '.' both indicate a queen and an empty space
 * respectively.
 * 
 * Example:
 * 
 * 
 * Input: 4
 * Output: [
 * ⁠[".Q..",  // Solution 1
 * ⁠ "...Q",
 * ⁠ "Q...",
 * ⁠ "..Q."],
 * 
 * ⁠["..Q.",  // Solution 2
 * ⁠ "Q...",
 * ⁠ "...Q",
 * ⁠ ".Q.."]
 * ]
 * Explanation: There exist two distinct solutions to the 4-queens puzzle as
 * shown above.
 * 
 * 
 */
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        // dfs; backtracking
        // tc:O(n^2); sc:O(n)
        if(n <= 0) {
            return new List<IList<string>>();
        }
        IList<IList<string>> res = new List<IList<string>>();
        List<int> path = new List<int>(); // store the column number of each queen
        Search(res, path, n);
        return res;
    }
    
    // row has been set, i-th queen should be placed at i-th row; only consider columns
    private void Search(IList<IList<string>> res, List<int> path, int n) {
        if(path.Count == n) { // all the queen have been placed
            res.Add(DrawChessBoard(path)); // based on the path, draw the queen chessboard
            return;
        }
        for(int colIndex = 0; colIndex < n; colIndex++) {
            if(!IsValid(path, colIndex)) {
                continue;
            }
            path.Add(colIndex);
            Search(res, path, n);
            path.RemoveAt(path.Count - 1);
        }
    }
    
    private bool IsValid(List<int> path, int colIndex) {
        int row = path.Count; // this queen should be placed at rowNum of row
        for(int rowIndex = 0; rowIndex < row; rowIndex++) {
            if(path[rowIndex] == colIndex) { // previous queen and current queen are in same column
                return false;
            }
            if(path[rowIndex] - rowIndex == colIndex - row) { // previous and current queen are in same main diagnonal
                return false;
            }
            if(path[rowIndex] + rowIndex == colIndex + row) { // previous and current queen are in same vice diagnonal
                return false;
            }
        }
        return true;
    }
    
    private IList<string> DrawChessBoard(List<int> path) {
        IList<string> solution = new List<string>();
        for(int row = 0; row < path.Count; row++) {
            StringBuilder str = new StringBuilder();
            for(int col = 0; col < path.Count; col++) {
                if(path[row] == col) {
                    str.Append('Q');
                }
                else{
                    str.Append('.');
                }
            }
            solution.Add(str.ToString());
        }
        return solution;
    }
}

