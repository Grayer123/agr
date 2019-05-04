public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        // hashset;
        // tc:O(n); sc:O(n)
        if(nums1 == null || nums1.Length == 0 || nums2 == null || nums2.Length == 0) {
            return new int[0];
        }
        // HashSet<int> hashset = new HashSet<int>(nums1);
        HashSet<int> hashset = nums1.ToHashSet();
        // foreach(int num in nums1) {
        //     hashset.Add(num); // return true if num does not exist while return false while num exists already
        // }
        List<int> res = new List<int>();
        foreach(int num in nums2) {
            if(hashset.Contains(num)) {
                res.Add(num);
                hashset.Remove(num); //HashSet.Remove(T) return true if can find and remove the element, otherwise return false
            }
        }
        return res.ToArray();
    }
}