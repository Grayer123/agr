public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        // hash table 
        // tc:O(n); sc:O(n)
        if(nums1.Length == 0 || nums2.Length == 0){ //corner case
            return new int[0];
        }
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> res = new List<int>();
        foreach(int num in nums1) {
            dict[num] = dict.ContainsKey(num) ? ++dict[num] : 1;
        }
        foreach(int num in nums2) {
            if(dict.ContainsKey(num)) {
                res.Add(num);
                dict[num]--;
                if(dict[num] == 0) {
                    dict.Remove(num);
                }
            }
        }
        return res.ToArray();
    }
}