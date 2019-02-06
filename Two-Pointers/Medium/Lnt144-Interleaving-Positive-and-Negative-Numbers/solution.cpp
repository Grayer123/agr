class Solution {
public:
    /*
     * @param A: An integer array.
     * @return: nothing
     */
    void rerange(vector<int> &nums) {
        // partition + two pointers
        if(nums.size() < 3) {
            return;
        }
        int pos = partition(nums);
        int numNegtive = pos, numPositive = nums.size() - pos;
        int left, right;
        if(numNegtive < numPositive) {
            left = 0;
            right = nums.size() - 2;
        }
        else if(numNegtive == numPositive) {
            left = 1;
            right = nums.size() - 2;
        }
        else {
            left = 1;
            right = nums.size() - 1;
        }
        while(left < right) {
            swap(nums[left], nums[right]);
            left += 2;
            right -= 2;
        }
        
    }
private:
    // to find the pos of elem >= 0 [<0, >=0]
    int partition(vector<int>& nums) {
        int pivot = 0;
        int left = 0, right = nums.size() - 1;
        while(left <= right) {
            while(left <= right && nums[left] < pivot) {
                left++;
            }
            while(left <= right && nums[right] >= pivot) {
                right--;
            }
            if(left <= right) {
                swap(nums[left], nums[right]);
                left++;
                right--;
            }
        }
        return left;
    }
};