/*
 * @lc app=leetcode id=212 lang=csharp
 *
 * [212] Word Search II
 *
 * https://leetcode.com/problems/word-search-ii/description/
 *
 * algorithms
 * Hard (27.98%)
 * Total Accepted:    105.3K
 * Total Submissions: 375.4K
 * Testcase Example:  '[["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]]\n["oath","pea","eat","rain"]'
 *
 * Given a 2D board and a list of words from the dictionary, find all words in
 * the board.
 * 
 * Each word must be constructed from letters of sequentially adjacent cell,
 * where "adjacent" cells are those horizontally or vertically neighboring. The
 * same letter cell may not be used more than once in a word.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Input: 
 * board = [
 * ⁠ ['o','a','a','n'],
 * ⁠ ['e','t','a','e'],
 * ⁠ ['i','h','k','r'],
 * ⁠ ['i','f','l','v']
 * ]
 * words = ["oath","pea","eat","rain"]
 * 
 * Output: ["eat","oath"]
 * 
 * 
 * 
 * 
 * Note:
 * 
 * 
 * All inputs are consist of lowercase letters a-z.
 * The values of words are distinct.
 * 
 * 
 */
public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        // dfs + backtracking + prefix dictionary
        // tc:O(m*n*4^(k-1)); sc:O(m*n)
        if(board == null && board.Length == 0) { //corner case
            return new List<string>();
        }
        bool[,] visited = new bool[board.Length, board[0].Length];
        var prefixSet = GetPrefixSet(words);
        IList<string> res = new List<string>();
        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board[i].Length; j++) {                
                FindWord(board, visited, res, prefixSet, board[i][j].ToString(), i, j);
            }
        }   
        return res;
    }
    
    // create prefix dictionary to replace trie tree
    private Dictionary<string, bool> GetPrefixSet(string[] words) {
        Dictionary<string, bool> dict = new Dictionary<string, bool>();
        foreach(string word in words) {
            for(int i = 1; i < word.Length; i++) {
                string sub = word.Substring(0, i);
                if(!dict.ContainsKey(sub)) {
                    dict[sub] = false;
                }
            }
            dict[word] = true;
        }
        return dict;
    }
    
    private void FindWord(char[][] board, bool[,] visited, IList<string> res, Dictionary<string, bool> prefixSet, string path, int x, int y) {
        if(!prefixSet.ContainsKey(path)) {
            return;
        }
        visited[x, y] = true;
        if(prefixSet[path]) {
            res.Add(path);
            prefixSet[path] = false;  //avoid words add multiple times => bee; beet
            // return;  // need to keep finding
        }       
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};
        for(int i = 0; i < 4; i++) {
            int newX = x + dx[i];
            int newY = y + dy[i];
            if(IsValid(board, newX, newY) && !visited[newX, newY]) {
                FindWord(board, visited, res, prefixSet, path + board[newX][newY], newX, newY);
            }
        }
        visited[x, y] = false;  // backtracking
    }
    
    private bool IsValid(char[][] board, int x, int y) {
        return x >= 0 && x < board.Length && y >= 0 && y < board[0].Length;
    }
}

