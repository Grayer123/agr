public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        //binary search
        //TC:O(logn); SC:O(1)
        int len1 = nums1.Length, len2 = nums2.Length;
        double median = 0;
        if((len1 + len2) % 2 != 0){
            median = FindKth(ref nums1, ref nums2, (len1 + len2) / 2 + 1, 0, 0);
        }
        else{
            median = (double)(FindKth(ref nums1, ref nums2, (len1 + len2) / 2, 0, 0) 
                              + FindKth(ref nums1, ref nums2, (len1 + len2) / 2 + 1, 0 , 0)) / 2;
        }
        return median;
    }
    
    int FindKth(ref int[] nums1, ref int[] nums2, int k, int start1, int start2){
        if(k == 1){
            return Math.Min(start1 >= nums1.Length ? Int32.MaxValue : nums1[start1], 
                            start2 >= nums2.Length ? Int32.MaxValue : nums2[start2]);
        }
        int num1 = start1 + k / 2 - 1 < nums1.Length ? nums1[start1 + k / 2 - 1] : Int32.MaxValue;
        int num2 = start2 + k / 2 - 1 < nums2.Length ? nums2[start2 + k / 2 - 1] : Int32.MaxValue;
        if(num1 <= num2){
            return FindKth(ref nums1, ref nums2, k - k / 2, start1 + k / 2, start2);
        }
        else{
            return FindKth(ref nums1, ref nums2, k - k / 2, start1, start2 + k / 2);
        }
    }
}