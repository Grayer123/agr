/*
 * @lc app=leetcode id=52 lang=csharp
 *
 * [52] N-Queens II
 *
 * https://leetcode.com/problems/n-queens-ii/description/
 *
 * algorithms
 * Hard (51.04%)
 * Total Accepted:    95.4K
 * Total Submissions: 186.3K
 * Testcase Example:  '4'
 *
 * The n-queens puzzle is the problem of placing n queens on an n×n chessboard
 * such that no two queens attack each other.
 * 
 * 
 * 
 * Given an integer n, return the number of distinct solutions to the n-queens
 * puzzle.
 * 
 * Example:
 * 
 * 
 * Input: 4
 * Output: 2
 * Explanation: There are two distinct solutions to the 4-queens puzzle as
 * shown below.
 * [
 * [".Q..",  // Solution 1
 * "...Q",
 * "Q...",
 * "..Q."],
 * 
 * ["..Q.",  // Solution 2
 * "Q...",
 * "...Q",
 * ".Q.."]
 * ]
 * 
 * 
 */
public class Solution {
    public int TotalNQueens(int n) {
        // dfs; backtracking
        // tc:O(n^2); sc:O(n)
        if(n <= 0) {
            return 0;
        }
        int sum = 0;
        List<int> path = new List<int>(); // store the column number of each queen
        Search(path, n, ref sum);
        return sum;
    }
    
    // row has been set, i-th queen should be placed at i-th row; only consider columns
    private void Search(List<int> path, int n, ref int sum) {
        if(path.Count == n) { // all the queen have been placed
            sum++;
            return;
        }
        for(int colIndex = 0; colIndex < n; colIndex++) {
            if(!IsValid(path, colIndex)) {
                continue;
            }
            path.Add(colIndex);
            Search(path, n, ref sum);
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
}

