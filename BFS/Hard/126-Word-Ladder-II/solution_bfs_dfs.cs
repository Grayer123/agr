public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        // bfs + dfs
        if(wordList.Count == 0) {
            return new List<IList<string>>();
        }
        HashSet<string> dict = wordList.ToHashSet();
        dict.Add(beginWord);
        Dictionary<string, int> levelDict = new Dictionary<string, int>(); // dictionary to record the level for each node
        levelDict[beginWord] = 0;
        var ladders = Bfs(dict, levelDict, beginWord, endWord);
        if(ladders == null) {
            return new List<IList<string>>();
        }
        List<IList<string>> res = new List<IList<string>>();
        List<string> row = new List<string>();
        Dfs(ladders,  levelDict, res, row, beginWord, endWord);
        return res;
    }

    private Dictionary<string, List<string>> Bfs(HashSet<string> dict, Dictionary<string, int> levelDict, string start, string end) {
        Dictionary<string, List<string>> ladders = new Dictionary<string, List<string>>(); // consruct the graph, get neighbors for every node
        foreach(string str in dict) {
            ladders[str] = new List<string>();
        }
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(start);
        while(queue.Count > 0) {
            int levelSize = queue.Count;
            for(int i = 0; i < levelSize; i++) {  // level order traversal
                string word = queue.Dequeue();
                foreach(var ngb in MakeLadders(ladders, dict, queue, word)) {
                    ladders[word].Add(ngb);  // Add all neighbors to the node in dictionary
                    if(!levelDict.ContainsKey(ngb)) { // keep the level for each node
                        levelDict[ngb] = levelDict[word] + 1;
                        if(ngb == end) {
                            break;
                        }
                        queue.Enqueue(ngb);                        
                    }
                }
            }
        }
        return ladders.Count == 0 ? null : ladders;
    }
        
    private List<string> MakeLadders(Dictionary<string, List<string>> ladders, HashSet<string> dict, Queue<string> queue, string key) {  
        char[] arr = key.ToCharArray();     // method to get all neighbors for every node
        List<string> neighbors = new List<string>(); 
        for(int i = 0; i < key.Length; i++) {
            char cur = key[i];
            for(char ch = 'a'; ch <= 'z'; ch++) {
                if(cur != ch) {
                    arr[i] = ch;               
                    string newWord = new String(arr);
                    if(dict.Contains(newWord)) {
                        neighbors.Add(newWord);
                    }
                }
            }
            arr[i] = cur;
        }
        return neighbors;
    }
        
    private void Dfs(Dictionary<string, List<string>> ladders, Dictionary<string, int> levelDict, List<IList<string>> res, List<string> row, string startWord, string endWord) {
        row.Add(startWord);
        if(startWord == endWord) {
            res.Add(new List<string>(row));
            return;
        }
        foreach(var word in ladders[startWord]) {
            if(levelDict[word] == levelDict[startWord] + 1) { // to make sure only explore the nodes with next level (eg: from n to n+1)
                Dfs(ladders, levelDict, res, row, word, endWord);
                row.RemoveAt(row.Count - 1);
            }
        }
    }
}
