public class NumArray {
    // prefixSum array
    public NumArray(int[] nums) {
        if(nums == null) {
            return;
        }
        prefixSumArr = new int[nums.Length + 1];
        prefixSumArr[0] = 0;
        for(int i = 0; i < nums.Length; i++) {
            prefixSumArr[i + 1] = prefixSumArr[i] + nums[i];
        }
    }
    
    public int SumRange(int i, int j) {
        return prefixSumArr[j + 1] - prefixSumArr[i];
    }
    
    private int[] prefixSumArr;
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */