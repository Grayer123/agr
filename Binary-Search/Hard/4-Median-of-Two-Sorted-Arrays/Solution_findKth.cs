public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // find kth in sorted arrays; divide and conquer 
        // tc:O(log(n+m)); sc:O(n)
        // assume both arrays are not null
        if(nums1.Length == 0 && nums2.Length == 0) {
            throw new Exception("Invalid input");
        }
        int len1 = nums1.Length, len2 = nums2.Length;
        if((len1 + len2) % 2 != 0) {
            return FindKth(nums1, 0, nums2, 0, (len1 + len2) / 2 + 1);
        }
        else {
            return (FindKth(nums1, 0, nums2, 0, (len1 + len2) / 2) + FindKth(nums1, 0, nums2, 0, (len1 + len2) / 2 + 1)) / 2;
        }
    }
    
    // find kth in sorted array
    private double FindKth(int[] nums1, int start1, int[] nums2, int start2, int k) {
        if(k == 1) {
            return Math.Min(start1 >= nums1.Length ? Int32.MaxValue : nums1[start1], start2 >= nums2.Length ? Int32.MaxValue : nums2[start2]);
        }
        if(start1 + k / 2 - 1 >= nums1.Length) {
            return FindKth(nums1, start1, nums2, start2 + k / 2, k - k / 2);
        }
        else if(start2 + k / 2 - 1 >= nums2.Length) {
            return FindKth(nums1, start1 + k / 2, nums2, start2, k - k / 2);
        }
        int num1 = nums1[start1 + k / 2 - 1], num2 = nums2[start2 + k / 2 - 1];
        if(num1 < num2) {
            return FindKth(nums1, start1 + k / 2, nums2, start2, k - k / 2);
        }
        else {
            return FindKth(nums1, start1, nums2, start2 + k / 2, k - k / 2);
        }
    }
}