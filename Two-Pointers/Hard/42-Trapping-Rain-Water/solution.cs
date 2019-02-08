public class Solution {
    public int Trap(int[] height) {
        // two opposite pointers
        // TC:O(n); SC:O(1)
        if(height == null || height.Length <= 2) {
            return 0;
        }
        int leftBase = 0, rightBase = 0;
        int left = 0, right = height.Length - 1;
        int area = 0;
        while(left < right) {
            if(height[left] <= height[right]) { // have a right base, left side start
                if(leftBase > height[left]) { // already have right base, now have a left base (rightBase > leftBase)
                    area += leftBase - height[left];
                }
                else {
                    leftBase = height[left];
                }
                left++;
            }
            else { // have a left base, right side start
                if(rightBase > height[right]) { // already have left base, now have a right base (leftBase > rightBase)
                    area += rightBase - height[right];
                }
                else {
                    rightBase = height[right];
                }
                right--;
            }
        }
        return area;
    }
}