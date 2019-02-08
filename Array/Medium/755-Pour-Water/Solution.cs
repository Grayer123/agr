public class Solution {
    public int[] PourWater(int[] heights, int v, int k) {
        // array
        // TC:O(nv); SC:O(1)
        if(heights == null || heights.Length < 1 || heights.Length < k) {
            return heights;
        }
        for(int i = v; i > 0; i--) {
            int cur = k;
            
            while(left >= 0) {
                if(heights[left] > heights[cur]) {
                    break;
                }
                if(heights[left] < heights[cur]) {
                    cur = left;
                }
                left--;
            }
            if(cur == k) {
                while(right < heights.Length) {
                    if(heights[right] > heights[cur]) {
                        break;
                    }
                    if(heights[right] < heights[cur]) {
                        cur = right;
                    }
                    right++;
                }
            }
            heights[cur]++;
        }
       return heights; 
    }
}