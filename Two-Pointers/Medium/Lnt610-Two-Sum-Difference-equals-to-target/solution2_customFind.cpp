class Solution {
public:
    /**
     * @param nums: an array of Integer
     * @param target: an integer
     * @return: [index1 + 1, index2 + 1] (index1 < index2)
     */
    vector<int> twoSum7(vector<int> &nums, int target) {
        // two pointers
        // tc:O(nlogn); sc:O(n)
        if(nums.size() < 2) {
            return vector<int>();
        }
        auto sortedNums = nums;
        sort(sortedNums.begin(), sortedNums.end());
        target = abs(target);
        for(int i = 0; i < sortedNums.size() - 1; i++) {
            int j = i + 1;
            while(j < sortedNums.size() && sortedNums[j] - sortedNums[i] <= target) {
                if(sortedNums[j] - sortedNums[i] == target) {
                    return findElems(nums, sortedNums[i], sortedNums[j]);
                }
                j++;
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
