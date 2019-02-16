class Solution {
public:
    /**
     * @param nums: an array of Integer
     * @param target: an integer
     * @return: [index1 + 1, index2 + 1] (index1 < index2)
     */
    vector<int> twoSum7(vector<int> &nums, int target) {
        // two pointers
        // tc:O(n); sc:O(1)
        if(nums.size() < 2) {
            return {};
        }
        vector<int> sortedNums = nums;
        sort(sortedNums.begin(), sortedNums.end());
        
        int slow = 0, fast = 1;
        target = abs(target);
        while(fast < nums.size()) {
            if(slow == fast || sortedNums[fast] - sortedNums[slow] < target) {
                fast++;
            }
            else if(sortedNums[fast] - sortedNums[slow] > target) {
                slow++;
            }
            else{
                int idx1 = find(nums.begin(), nums.end(), sortedNums[slow]) - nums.begin() + 1;
                int idx2 = nums.rend() - find(nums.rbegin(), nums.rend(), sortedNums[fast]);
                return {idx1 < idx2 ? idx1 : idx2, idx1 < idx2 ? idx2: idx1};
            }
        }
        return {};
    }
};