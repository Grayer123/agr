class Solution {
public:
    /**
     * @param nums: The integer array you should partition
     * @param k: An integer
     * @return: The index after partition
     */
    int partitionArray(vector<int> &nums, int k) {
        // quick select
        // TC:O(n); SC:O(1)
        if(nums.size() < 2) {
            return 0;
        }
        int left = 0, right = nums.size() - 1;
        while(left <= right) {
            while(left <= right && nums[left] < k) {
                left++;
            }
            while(left <= right && nums[right] >= k) {
                right--;
            }
            if(left <= right) {
                int tmp = nums[left];
                nums[left] = nums[right];
                nums[right] = tmp;
                left++;
                right--;
            }
        }
        return left;
    }

    
};