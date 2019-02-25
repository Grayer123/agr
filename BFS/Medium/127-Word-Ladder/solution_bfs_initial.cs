public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        // bfs
        // tc:O(nl); sc:O(n)
        if(wordList.Count == 0 || !wordList.Contains(endWord) || beginWord == endWord) { // endword must in wordList
            return 0;
        }
        HashSet<string> dict = new HashSet<string>();
        foreach(string word in wordList) { // preprocessing: find in hashset is faster than in list
            dict.Add(word);
        }
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        int level = 0;
        queue.Enqueue(beginWord);
        while(queue.Count > 0) {
            level++;
            int levelSize = queue.Count;
            for(int i = 0; i < levelSize; i++) {
                string str = queue.Dequeue();
                if(FindTransformWords(str, endWord, visited, dict, queue)) {
                    return level + 1;
                } 
            }
        }
        return 0;
        
    }
    
    private bool FindTransformWords(string word, string target, HashSet<string> visited, HashSet<string> dict, Queue<string> queue) {
        for(int i = 0; i < word.Length; i++) {
            for(var j = 'a'; j <= 'z'; j++) {
                StringBuilder str = new StringBuilder(word);
                str[i] = j;
                string newWord = str.ToString();
                if(newWord == target) {
                    return true;
                }
                if(!visited.Contains(newWord) && dict.Contains(newWord)) {
                    queue.Enqueue(newWord);
                    visited.Add(newWord);
                }
            }
        }
        return false;
    }
}