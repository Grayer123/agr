public class Solution {
    public int MaxArea(int[] height) {
        // two opposite pointers
        // TC:O(n); SC:O(1)
        if(height.Length < 2) {
            return 0;
        }
        int left = 0, right = height.Length - 1;
        int maxArea = 0, area = 0;
        while(left < right) {
            if(height[left] < height[right]) {
                area = (right - left) * height[left];
                left++;
            }
            else {
                area = (right - left) * height[right];
                right--;
            }            
            maxArea = Math.Max(area, maxArea);
        }
        return maxArea;
    }
}