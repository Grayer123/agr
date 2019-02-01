class Solution {
public:
    /**
     * @param nums: A list of integer which is 0, 1 or 2 
     * @return: nothing
     */
    void sortColors(vector<int> &nums) {
        // three pointers (cur, left, right)
        // one iteration; TC:O(n); SC:O(1)
        if(nums.size() <= 1) { //corner case
            return;
        }
        int left = 0, cur = 0, right = nums.size() - 1;
        while(cur <= right) {
            if(nums[cur] == 0) {
                swap(nums[left], nums[cur]);
                left++;
                cur++;
            }
            else if(nums[cur] == 2) {
                swap(nums[right], nums[cur]);
                right--;
            }
            else{
                cur++;
            }
        }
    }
};