public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        // sort + two pointers;
        // tc:O(nlogn + mlogm); sc:O(1)
        if(nums1.Length == 0 || nums2.Length == 0){ //corner case
            return new int[0];
        }
        Array.Sort(nums1);
        Array.Sort(nums2);
        int pos1 = 0, pos2 = 0;
        List<int> res = new List<int>();
        while(pos1 < nums1.Length && pos2 < nums2.Length) {
            if(nums1[pos1] < nums2[pos2]) {
                pos1++;
            }
            else if(nums1[pos1] > nums2[pos2]) {
                pos2++;
            }
            else {
                if(res.Count == 0 || res[res.Count - 1] != nums1[pos1]) {
                    res.Add(nums1[pos1]);
                }
                pos1++;
                pos2++;
            }
        }
        return res.ToArray();
    }
}