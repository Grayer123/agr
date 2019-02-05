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
        return partition(nums, 0, nums.size() - 1, nums.size() - k + 1); // convert k smallest to (len-k+1) largest
        
    }
private:
    int partition(vector<int>& nums, int start, int end, int k) {
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
        if(end - left + 1 >= k) {
            return partition(nums, left, end, k);
        }
        else {
            // left, right might not be adjacent (left, x, right) => so use left - 1 instead of right
            // x = k-(end-left+1): means kth elem not in right side; find xth largest in left side
            return partition(nums, start, left - 1, k - (end - left + 1));
        }
    }
};