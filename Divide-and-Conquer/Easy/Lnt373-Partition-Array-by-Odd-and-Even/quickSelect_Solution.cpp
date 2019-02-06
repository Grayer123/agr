class Solution {
public:
    void partitionArray(vector<int> &nums) {
        // quick select: partition
        // tc:O(n); sc:O(1)
        if(nums.size() < 2) {
            return;
        }

        int left = 0, right = nums.size() - 1;
        while(left <= right) {
            while(left <= right && (nums[left] & 0x01) == 1) {
                left++;
            }
            while (left <= right && (nums[right] & 0x01) == 0) {
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
    }
};