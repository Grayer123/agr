public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // two pointers: in place, move from end to start
        // tc:O(m + n); sc:O(1)
        if(nums2 == null || nums2.Length == 0 || n <= 0) {
            return;
        }
        int end1 = m - 1, end2 = n - 1;
        // int pos = nums1.Length - 1;
        int pos = m + n - 1;
        while(end1 >= 0 && end2 >= 0) {
            nums1[pos--] = nums1[end1] <= nums2[end2] ? nums2[end2--] : nums1[end1--];
        }
        while(end2 >= 0) {
            nums1[pos--] = nums2[end2--];
        }
    }
}