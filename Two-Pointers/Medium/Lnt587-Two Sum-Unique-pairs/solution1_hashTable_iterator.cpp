class Solution {
public:
    int twoSum6(vector<int> &nums, int target) {
        // hash table with iterator
        // TC:O(n); SC:O(n)
        if(nums.size() < 2) {
            return 0;
        }
        int res = 0;
        unordered_map<int, int> hashTable;
        for(int num : nums) {
            hashTable[num]++;
        }

        for(auto it = hashTable.begin(); it != hashTable.end(); ) {
            int toFind = target - it->first;
            if(hashTable.find(toFind) != hashTable.end()) {
                if(hashTable[toFind] > 1 || toFind != it->first) {
                    res++;
                    hashTable.erase(it->first);
                    hashTable.erase(toFind);
                    it = hashTable.begin();
                }
                else {
                    it++;
                }
            }
            else{
                it++;
            }
        }
        return res;
    }
};