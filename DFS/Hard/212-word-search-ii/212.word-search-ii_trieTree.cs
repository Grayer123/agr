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
public class TrieNode {
    public string word;
    public Dictionary<char, TrieNode> children;
    public TrieNode() {
        this.children = new Dictionary<char, TrieNode>();
    }
} 

public class TrieTree {
    public TrieNode root;
    public TrieTree(TrieNode node) {
        root = node;
    }
    public void InsertNode(string str) {
        TrieNode node = root;
        foreach(char ch in str) {
            if(!node.children.ContainsKey(ch)) {
                node.children[ch] = new TrieNode();
            }
            node = node.children[ch];
        }
        node.word = str; // word at this node
    }
}


public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        // dfs + backtracking
        // tc:O(m*n*4^(k-1)); sc:O(m*n)
        if(board == null && board.Length == 0) { //corner case
            return new List<string>();
        }
        bool[,] visited = new bool[board.Length, board[0].Length];
              
        TrieTree trie = new TrieTree(new TrieNode()); // build the trie tree
        foreach(string wd in words) {  // insert words into trie tree
            trie.InsertNode(wd);
        }
        
        IList<string> res = new List<string>();
        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board[i].Length; j++) {                
                SearchWord(board, visited, res, trie.root, i, j);
            }
        }   
        return res;
    }
    
    private void SearchWord(char[][] board, bool[,] visited, IList<string> res, TrieNode root, int x, int y) {
        if(!root.children.ContainsKey(board[x][y])) {
            return;
        }
        visited[x, y] = true;
        root = root.children[board[x][y]];
        if(root.word != null) {
            res.Add(root.word);
            root.word = null;  //avoid words add multiple times => bee; beet
            // return;  // need to keep finding
        }       
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};
        for(int i = 0; i < 4; i++) {
            int newX = x + dx[i];
            int newY = y + dy[i];
            if(IsValid(board, newX, newY) && !visited[newX, newY]) {
                SearchWord(board, visited, res, root, newX, newY);
            }
        }
        visited[x, y] = false;  // backtracking
    }
    
    private bool IsValid(char[][] board, int x, int y) {
        return x >= 0 && x < board.Length && y >= 0 && y < board[0].Length;
    }
}
