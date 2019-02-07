class Solution {
public:
    /**
     * @param k: An integer
     * @param nums: An integer array
     * @return: kth smallest element
     */
    int kthSmallest(int k, vector<int> &nums) {
        // quick select
        // tc:O(n); sc:O(1)
        if(nums.size() < k) {
            throw std::invalid_argument("Invalid Input.");
        }
        return quickSelect(nums, 0, nums.size() - 1, k);
        
    }
private:
    int quickSelect(vector<int>& nums, int start, int end, int k) {
        if(start >= end) {
            return nums[start];
        }
        int left = start, right = end;
        int pivot = nums[start + (end - start) / 2];
        while(left <= right) {
            while(left <= right && nums[left] < pivot) {
                left++;
            }
            while(left <= right && nums[right] > pivot) {
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
        if(right >= start && right - start + 1 >= k) {
            return quickSelect(nums, start, right, k);
        }
        // when nums[start] -> pivot, and this time left, right, start point to the same
        // left++, right-- -> this time, start > right => thus, right - start + 1 = 0
        // but actually the first part still have nums[start] elem => so seperate them
        else if(start > right) {
            return quickSelect(nums, left, end, k - 1);
        }
        else {
            return quickSelect(nums, right + 1, end, k - (right - start + 1));
        }
    }
};