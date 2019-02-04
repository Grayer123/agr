class Solution {
public:
    /**
     * @param S: A list of integers
     * @return: An integer
     */
    int triangleCount(vector<int> &nums) {
        // two pointers(opposite direction)
        // TC:O(n^2); SC:O(1)
        if(nums.size() < 3) {
            return 0;
        }
        int res = 0;
        sort(nums.begin(), nums.end());
        
        for(int i = nums.size() - 1; i > 1; i--) {
            int left = 0, right = i - 1;
            while(left < right) {
                if(nums[i] < nums[right] + nums[left]) {
                    res += right - left;
                    right--;
                }
                else {
                    left++;
                }
            }
        }
        return res;
    }
};