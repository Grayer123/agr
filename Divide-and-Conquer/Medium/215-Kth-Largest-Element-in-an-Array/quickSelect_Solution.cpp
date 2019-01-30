class Solution {
public:
    /**
     * @param n: An integer
     * @param nums: An array
     * @return: the Kth largest element
     */
    int kthLargestElement(int n, vector<int> &nums) {
        // quick select
        // tc: O(n); sc:O(1)
        if(nums.size() == 0) {
            return INT_MIN;
        }
        return quickSelect(nums, 0, nums.size() - 1, n);
        
    }

private:
    int quickSelect(vector<int>& nums, int start, int end, int k) {
        if(start >= end) {
            return nums[start];
        }
        int pivot = nums[start + (end - start) / 2];
        int left = start, right = end;
        
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
        if(end - left + 1 >= k) {
            return quickSelect(nums, left, end, k);
        }
        else {
            // left, right might not be adjacent (left, x, right) => so use left - 1 instead of right
            // x = k-(end-left+1): means kth elem not in right side; find xth largest in left side
            return quickSelect(nums, start, left - 1, k - (end - left + 1));
        }
    }
};