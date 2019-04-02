public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        // bfs: queue
        // tc:O(2^n * n); sc:O(n)
        if(s == null) {
            return new List<string>();
        }
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(s);
        for(int i = 0; i < s.Length; i++) {
            if(Char.IsDigit(s[i])) {
                continue;
            }
            int len = queue.Count;
            for(int j = 0; j < len; j++) {
                var str = queue.Dequeue();
                char[] charArr = str.ToCharArray();
                charArr[i] = Char.ToLower(s[i]);
                queue.Enqueue(new String(charArr));
                charArr[i] = Char.ToUpper(s[i]);
                queue.Enqueue(new String(charArr));
            }
        }
        return queue.ToList();       
    }
}