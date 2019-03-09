public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // hash table 
        // tc:O(n); sc:O(n)
        if(nums.Length < 2) {
            return false;
        }
        HashSet<int> hash = new HashSet<int>();
        foreach(int num in nums) {
            if(hash.Contains(num)) {
                return true;
            }
            hash.Add(num);
        }

        return false;
    }
}