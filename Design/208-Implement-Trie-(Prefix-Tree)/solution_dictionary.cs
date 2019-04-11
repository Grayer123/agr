public class TrieNode {
    public string word;
    public Dictionary<char, TrieNode> children;
    public TrieNode() {
        this.children = new Dictionary<char, TrieNode>();
    }
}


public class Trie {
    // implemented with dictionary
    public TrieNode root;

    /** Initialize your data structure here. */
    public Trie() {
        root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        TrieNode node = root;
        foreach(char ch in word) {
            if(!node.children.ContainsKey(ch)) {
                node.children[ch] = new TrieNode();
            }
            node = node.children[ch];
        }
        node.word = word;  // word ends at this node 
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        TrieNode node = root;
        foreach(char ch in word) {
            if(!node.children.ContainsKey(ch)) {
                return false;
            }
            node = node.children[ch];
        }
        return node.word == word;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        TrieNode node = root;
        foreach(char ch in prefix) {
            if(!node.children.ContainsKey(ch)) {
                return false;
            }
            node = node.children[ch];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */