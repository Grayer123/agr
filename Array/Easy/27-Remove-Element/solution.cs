public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //array; two pointers; from back to the front
        //tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0){
            return 0;
        }
        int dupCount = 0, count = 0;
        bool flag = false;
        for(int i = nums.Length - 1; i >= 0; i--){
            if(nums[i] == val){
                flag = true;
                dupCount++;
                continue;
            }          
            if(count++ != 0 && flag){
                MoveElems(ref nums, i + 1, dupCount, count - 1);
            }
            flag = false;
            dupCount = 0;                     
        }
        if(dupCount != 0){
            MoveElems(ref nums, 0, dupCount, count);
        }
        return count;
    }
    
    private void MoveElems(ref int[] nums, int curIdx, int dupCount, int count){
        int startIdx = curIdx + dupCount;
        for(int i = 0; i < count; i++){
            nums[curIdx + i] = nums[startIdx + i];
        }
    }
}