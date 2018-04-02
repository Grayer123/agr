public class TwoSum {
    // trade-off: more find, less add
    // tc: Add: O(n); Find: O(1); sc:O(n)
    private IList<int> list;
    private HashSet<int> hashset;
    /** Initialize your data structure here. */
    public TwoSum() {
        list = new List<int>();
        hashset = new HashSet<int>();
    }
    
    /** Add the number to an internal data structure.. */
    public void Add(int number) {
        if(list.Count != 0){
            foreach(int val in list){
                hashset.Add(val + number);
            }
        }
        list.Add(number);
    }
    
    /** Find if there exists any pair of numbers which sum is equal to the value. */
    public bool Find(int value) {
        return hashset.Contains(value);
    }
}

/**
 * Your TwoSum object will be instantiated and called as such:
 * TwoSum obj = new TwoSum();
 * obj.Add(number);
 * bool param_2 = obj.Find(value);
 */