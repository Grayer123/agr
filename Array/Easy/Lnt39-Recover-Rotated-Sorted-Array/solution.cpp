class Solution {
public:
    void recoverRotatedSortedArray(vector<int> &nums) {
        // three times reverse
        // TC:O(n); SC:O(1)
        if(nums.size() < 2){ //corner case
            return;
        }
        int reversePos = -1;
        int prev = nums[0];
        for(int i = 1; i < nums.size(); i++){
            if(nums[i] < prev){
                reversePos = i;
            }
            prev = nums[i];
        }
        if(reversePos == -1){ //no change to the original array
            return;
        }
        reverseArray(nums, 0, reversePos - 1);
        reverseArray(nums, reversePos, nums.size() - 1);
        reverseArray(nums, 0, nums.size() - 1);
    }
    
    void reverseArray(vector<int>& nums, int start, int end){
        while(start < end){
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
};