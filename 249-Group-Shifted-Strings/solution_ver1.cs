public class Solution {
    public IList<IList<string>> GroupStrings(string[] strings) {
        //hash table; string
        //TC:O(n); SC:O(n)
        if(strings == null){
            throw new ArgumentException("Invalid input.");
        }
        IList<IList<string>> res = new List<IList<string>>();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string s in strings){
            string sft = ShiftHelper(s);
            if(!dict.ContainsKey(sft)){
                dict.Add(sft, new List<string>());
            }
            dict[sft].Add(s);
        }
        foreach(var p in dict){
            res.Add(p.Value);
        }
        return res;
    }
    
    public string ShiftHelper(string s){
        StringBuilder key = new StringBuilder();
        for(int i = 1; i < s.Length; i++){
            int diff = s[i] - s[i - 1];
            diff = diff < 0 ? diff + 26 : diff;
            key.Append('a' + diff);
        }
        return key.ToString();
    }
}