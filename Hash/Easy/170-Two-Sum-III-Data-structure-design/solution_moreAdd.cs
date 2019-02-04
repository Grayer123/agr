public class TwoSum {
    // trade-off: more Add, less Find
    // tc: Add: O(1); Find: O(n); sc:O(n)
    private Dictionary<int, int> dict;
    /** Initialize your data structure here. */
    public TwoSum() {
        dict = new Dictionary<int, int>();
    }
    
    /** Add the number to an internal data structure.. */
    public void Add(int number) {
        if(dict.ContainsKey(number)){
            dict[number]++;
        }
        else{
            dict[number] = 1;
        }
    }
    
    /** Find if there exists any pair of numbers which sum is equal to the value. */
    public bool Find(int value) {
        foreach(var key in dict.Keys) {
            int target = value - key;
            if(dict.ContainsKey(target)) {
                if(key != target || dict[key] >= 2) { // val = 6 {1,5} or {3,3}
                    return true;
                }
            }
        }
        return false;
    }
    // public bool Find(int value) {
    //     foreach(var key in dict.Keys) {
    //         int target = value - key;
    //         if(dict.ContainsKey(target)) {
    //             if(key == target) { 
    //                 if(dict[key] > 1) {
    //                     return true;
    //                 }
    //             }
    //             else {
    //                 return true;
    //             }
    //         }
    //     }
    //     return false;
    // }
}

/**
 * Your TwoSum object will be instantiated and called as such:
 * TwoSum obj = new TwoSum();
 * obj.Add(number);
 * bool param_2 = obj.Find(value);
 */