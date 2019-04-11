public class Solution {
    public IList<string> GenerateAbbreviations(string word) {
        // dfs + backtracking
        // tc:O(2^n * n); sc:O(n)
        if(word == null) { // if word == string.Empty => return [""] instead of []
            return new List<string>();
        }
        IList<string> res = new List<string>();
        GetWords(word, res, "", 0, 0);
        return res;
    }
    
    private void GetWords(string word, IList<string> res, string str, int pos, int count) { // count: how many digits will be abbreviated
        if(pos >= word.Length) {
            if(count > 0) {
                str += count.ToString();
            }
            res.Add(str.ToString());
            return;
        }
        
        GetWords(word, res, str, pos + 1, count + 1);  // abbreviate
        
        if(count != 0) { // not abbreviate
            str += count.ToString();
        }
        str += word[pos];
        GetWords(word, res, str, pos + 1, 0);
    }
}