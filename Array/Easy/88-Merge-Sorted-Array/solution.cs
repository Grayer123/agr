public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //two pointers: in place, move from end to start
        //TC:O(n); SC:O(1)
        if(m < 0 || n < 0 || nums1.Length == 0){ //corner case
            return;
        }
        int end1 = m - 1, end2 = n - 1;
        while(end1 >= 0 && end2 >= 0){
            nums1[end1 + end2 + 1] = nums1[end1] >= nums2[end2] ? nums1[end1--] : nums2[end2--];
        }
        while(end2 >= 0){
            nums1[end2] = nums2[end2--];
        }
    }
}