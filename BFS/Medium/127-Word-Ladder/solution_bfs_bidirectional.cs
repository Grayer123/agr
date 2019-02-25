public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        // bidirectional bfs
        // tc:O(nl); sc:O(n)
        if(wordList.Count == 0 || !wordList.Contains(endWord) || beginWord == endWord) { // endword must in wordList
            return 0;
        }
        HashSet<string> dict = wordList.ToHashSet(); // preprocessing: find in hashset is faster than in list
        
        HashSet<string> startVisited = new HashSet<string>(); // hashset to record start visited 
        HashSet<string> endVisited = new HashSet<string>(); // hashset to record end visited 
        Queue<string> startQueue = new Queue<string>(); // queue for start
        Queue<string> endQueue = new Queue<string>(); // queue for end
        int level = 0;
        startQueue.Enqueue(beginWord);
        endQueue.Enqueue(endWord);
        while(startQueue.Count > 0 || endQueue.Count > 0) {    
            int startSize = startQueue.Count; // for the start queue
            level++; 
            for(int i = 0; i < startSize; i++) { 
                string str = startQueue.Dequeue();
                if(endVisited.Contains(str)) { // start and end meet
                    return level;
                }
                FindTransformWords(str, dict, startVisited, startQueue);
            }
            
            int endSize = endQueue.Count;  // for the end queue
            level++; 
            for(int i = 0; i < endSize; i++) { 
                string str = endQueue.Dequeue();
                if(startVisited.Contains(str)) {  // end and start meet
                    return level;
                }
                FindTransformWords(str, dict, endVisited, endQueue);
            }
        }
        return 0;
    }
    
    private void FindTransformWords(string word, HashSet<string> dict, HashSet<string> visited, Queue<string> queue) {
        for(int i = 0; i < word.Length; i++) {
            for(var j = 'a'; j <= 'z'; j++) {
                char[] arr = word.ToCharArray();
                arr[i] = j;
                string newWord = new String(arr);
                if(dict.Contains(newWord) && !visited.Contains(newWord)) {
                    queue.Enqueue(newWord);
                    visited.Add(newWord);
                }
            }
        }
    }
}