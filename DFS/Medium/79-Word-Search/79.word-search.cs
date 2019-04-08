/*
 * @lc app=leetcode id=79 lang=csharp
 *
 * [79] Word Search
 *
 * https://leetcode.com/problems/word-search/description/
 *
 * algorithms
 * Medium (30.76%)
 * Total Accepted:    265.2K
 * Total Submissions: 861.9K
 * Testcase Example:  '[["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]]\n"ABCCED"'
 *
 * Given a 2D board and a word, find if the word exists in the grid.
 * 
 * The word can be constructed from letters of sequentially adjacent cell,
 * where "adjacent" cells are those horizontally or vertically neighboring. The
 * same letter cell may not be used more than once.
 * 
 * Example:
 * 
 * 
 * board =
 * [
 * ⁠ ['A','B','C','E'],
 * ⁠ ['S','F','C','S'],
 * ⁠ ['A','D','E','E']
 * ]
 * 
 * Given word = "ABCCED", return true.
 * Given word = "SEE", return true.
 * Given word = "ABCB", return false.
 * 
 * 
 */
public class Solution {
    public bool Exist(char[][] board, string word) {
        // dfs + backtracking
        // tc:O(m*n*4^(k-1)); sc:O(m*n)
        if(board == null && board.Length == 0) { //corner case
            return false;
        }
        bool[,] visited = new bool[board.Length, board[0].Length];
        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board[i].Length; j++) {                
                if(FindWord(board, visited, word, 0, i, j)) {
                    return true;
                }
            }
        }   
        return false;
    }
    
    private bool FindWord(char[][] board, bool[,] visited, string word, int pos, int x, int y) {
        if(board[x][y] != word[pos]) {
            return false;
        }
        if(pos >= word.Length - 1) {
            return true;
        }
        visited[x, y] = true;
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};
        for(int i = 0; i < 4; i++) {
            int newX = x + dx[i];
            int newY = y + dy[i];
            if(IsValid(board, newX, newY) && !visited[newX, newY]) {
                if(FindWord(board, visited, word, pos + 1, newX, newY)) {
                    return true;
                }
            }
        }
        visited[x, y] = false;  // backtracking
        return false;
    }
    
    private bool IsValid(char[][] board, int x, int y) {
        return x >= 0 && x < board.Length && y >= 0 && y < board[0].Length;
    }
}

