public class Solution {
    public int LongestConsecutive(int[] nums) {
        // hashset
        // tc:O(n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return 0;
        }
        HashSet<int> hashset = new HashSet<int>();
        foreach(int num in nums) {
            hashset.Add(num);
        }
        int res = 0;
        foreach(int num in nums) {
            int len = 0;
            int curNum = num; // foreach loop does not allow mofidy elem so make a copy
            int lowerNum = num - 1;
            while(hashset.Contains(curNum)) { // expand the num up
                len++;
                hashset.Remove(curNum);  // num has been visited
                curNum++;               
            }
            int downLen = 0;
            while(hashset.Contains(lowerNum)) { // expand the num down
                len++;
                hashset.Remove(lowerNum);  // lowerNum has been visited
                lowerNum--;               
            }
            res = res < len ? len : res;
        }
        return res;
    }
}