public class Solution {
    public IList<int> PancakeSort(int[] A) {
        // partition; sorting
        // TC:O(n^2); SC:O(1)
        if(A.Length <= 1) {
            return new List<int>();
        }
        IList<int> res = new List<int>();
        int cur = A.Length - 1;
        while(cur > 0) {
            int pos = FindMax(A, cur);
            if(pos != cur) {
                res.Add(pos + 1);
                res.Add(cur + 1);
                Flip(A, pos);
                Flip(A, cur);
            }
            cur--;
        }
        return res;
    }
    
    private int FindMax(int[] nums, int end) {
        // find the max from index 0 ~ end, and return the index of max
        int max = nums[0], idx = 0;
        for(int i = end; i >= 0; i--) {
            if(max < nums[i]) {
                max = nums[i];
                idx = i;
            }
        }
        return idx;
    }
    
    private void Flip(int[] nums, int end) {
        // flip 0 ~ end elems upside down
        int start = 0;
        while(start <= end) {
            int tmp = nums[end];
            nums[end] = nums[start];
            nums[start] = tmp;
            start++;
            end--;
        }
    }
}