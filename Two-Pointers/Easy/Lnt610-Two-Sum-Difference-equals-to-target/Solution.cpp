class Solution {
public:
    /**
     * @param nums: an array of Integer
     * @param target: an integer
     * @return: [index1 + 1, index2 + 1] (index1 < index2)
     */
    vector<int> twoSum7(vector<int> &nums, int target) {
        // two pointers
        // tc:O(nlogn); sc:O(1)
        if(nums.size() < 2) {
            return vector<int>();
        }
        auto sortedNums = nums;
        sort(sortedNums.begin(), sortedNums.end());
        target = abs(target);
        int fast = 1;
        for(int slow = 0; slow < sortedNums.size() - 1; slow++) {
            while(fast < sortedNums.size() && sortedNums[fast] - sortedNums[slow] < target) {
                fast++;
            }
            if(sortedNums[fast] - sortedNums[slow] == target) {
                return findElems(nums, sortedNums[slow], sortedNums[fast]);
            }
        }
        return vector<int>();
    }
    
private:
    vector<int> findElems(vector<int> &nums, int target1, int target2) {
        vector<int> res;
        for(int i = 0; i < nums.size(); i++) {
            if(nums[i] == target1 || nums[i] == target2) {
                res.push_back(i + 1);
            }
        }
        return res;
    }
};