public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        //tc:O(n); sc:O(n)
        if(nums1.Length == 0 || nums2.Length == 0){ //corner case
            return new int[0];
        }
        HashSet<int> hs = new HashSet<int>(nums1); //initialize hashset with array nums1
        ICollection<int> collection = new System.Collections.ObjectModel.Collection<int>();
        foreach(int num in nums2){
            if(hs.Remove(num)){ //HashSet.Remove(T) return true if can find and remove the element, otherwise return false
                collection.Add(num);
            }
        }
        return collection.ToArray();
    }
}