public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        // bfs
        // tc:O(nl); sc:O(n)
        if(wordList.Count == 0 || !wordList.Contains(endWord) || beginWord == endWord) { // endword must in wordList
            return 0;
        }
        HashSet<string> dict = wordList.ToHashSet(); // preprocessing: find in hashset is faster than in list
        // foreach(string word in wordList) { 
        //     dict.Add(word);
        // }
        Queue<string> queue = new Queue<string>();
        int level = 0;
        queue.Enqueue(beginWord);
        while(queue.Count > 0) {
            level++;
            int levelSize = queue.Count; // maintain the level
            for(int i = 0; i < levelSize; i++) {
                string str = queue.Dequeue();
                if(str == endWord) {
                    return level;
                }
                FindTransformWords(str, dict, queue);
            }
        }
        return 0;
    }
    
    private void FindTransformWords(string word, HashSet<string> dict, Queue<string> queue) {
        for(int i = 0; i < word.Length; i++) {
            for(var j = 'a'; j <= 'z'; j++) {
                char[] arr = word.ToCharArray();
                arr[i] = j;
                string newWord = new String(arr);
                if(dict.Contains(newWord)) {
                    queue.Enqueue(newWord);
                    dict.Remove(newWord);
                }
            }
        }
    }
}