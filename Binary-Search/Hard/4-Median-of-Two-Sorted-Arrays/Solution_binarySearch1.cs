public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // binary search 
        // tc:O(log(range)∗(log(n)+log(m))); sc:O(n)
        // assume both arrays are not null
        if(nums1.Length == 0 && nums2.Length == 0) {
            throw new Exception("Invalid input");
        }
        int len1 = nums1.Length, len2 = nums2.Length;
        if((len1 + len2) % 2 != 0) {
            return FindKth(nums1, nums2, (len1 + len2) / 2 + 1);
        }
        else {
            return (FindKth(nums1, nums2, (len1 + len2) / 2) + FindKth(nums1, nums2, (len1 + len2) / 2 + 1)) / 2;
        }
    }
    
    // find kth in sorted array
    private double FindKth(int[] nums1, int[] nums2, int k) {
        if(nums1.Length == 0) {
            return nums2[k - 1];
        }
        if(nums2.Length == 0) {
            return nums1[k - 1];
        }
        int start = Math.Min(nums1[0], nums2[0]);
        int end = Math.Max(nums1[nums1.Length - 1], nums2[nums2.Length - 1]);
        while(start < end) {
            int mid = start + (end - start) / 2;
            int countNums1 = CountSmallerOrEqual(nums1, mid);
            int countNums2 = CountSmallerOrEqual(nums2, mid);
            if(countNums1 + countNums2 < k) {
                start = mid + 1;
            }
            else if(countNums1 + countNums2 == k) {
                return Math.Max(countNums1 == 0 ? Int32.MinValue : nums1[countNums1 - 1], countNums2 == 0 ? Int32.MinValue : nums2[countNums2 - 1]);
                //return mid;
            }
            else {
                end = mid;
            }
        }
        return start;
    }
    
    private int CountSmallerOrEqual(int[] nums, int target) {
        int start = 0, end = nums.Length - 1;
        while(start < end) {
            int mid = start + (end - start) / 2;
            if(nums[mid] <= target) {
                start = mid + 1;
            }
            else {
                end = mid - 1;
            }
        }
        if(nums[start] <= target) {
            return start + 1;
        }
        return start;
    } 
}