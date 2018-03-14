class Solution {
public:
    void recoverRotatedSortedArray(vector<int> &nums) {
        // three times reverse
        // TC:O(n); SC:O(1)
        if(nums.size() < 2){ //corner case
            return;
        }
        int reversePos = findMinPos(nums);
        reverse(nums.begin(), nums.begin() + reversePos);
        reverse(nums.begin() + reversePos, nums.end());
        reverse(nums.begin(), nums.end());
    }
    
    //auxiliary method: to find the pos of min
    int findMinPos(vector<int>& nums){
        int start = 0, end = nums.size() - 1;
        int cmp = nums[end];
        while(start < end){
            int mid = start + (end - start) / 2;
            if(nums[mid] == cmp){
                if(nums[start] == cmp){
                    start++;
                }
                else if(nums[end] == cmp){
                    end--;
                }
            }
            else if(nums[mid] < cmp){
                end  = mid;
            }
            else{
                start = mid + 1;
            }
        }
        return start;
    }
    
    //auxiliary method: to reverse a portion in the vector
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
