class Solution {
public:
    /*
     * @param nums: a list of integers
     * @return: A integer indicate the sum of minimum subarray
     */
    int minSubArray(vector<int> &nums) {
        // divide and conquer 
        // tc:O(nlogn); sc:O(n)
        if(nums.size() == 0) {
            throw "Invalid input exception.";
        }
        return divideAndConquer(nums, 0, nums.size() - 1);
    }

private:
    int divideAndConquer(vector<int>& nums, int start, int end) {
        if(start >= end) {
            return nums[end];
        }
        int mid = start + (end - start) / 2;
        return min(min(divideAndConquer(nums, start, mid), divideAndConquer(nums, mid + 1, end)), findCrossingMinSum(nums, start, mid, end));
    }
    
    int findCrossingMinSum(vector<int>& nums, int start, int mid, int end) {
        int sum = 0;
        int leftSum = nums[mid];
        for(int i = mid; i >= start; i--) {
            sum += nums[i];
            leftSum = min(leftSum, sum);
        }
        sum = 0;
        int rightSum = nums[mid + 1];
        for(int i = mid + 1; i <= end; i++) {
            sum += nums[i];
            rightSum = min(rightSum, sum);
        }
        return leftSum + rightSum;
    }
};