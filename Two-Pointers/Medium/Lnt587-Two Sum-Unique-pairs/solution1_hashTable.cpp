class Solution {
public:
    int twoSum6(vector<int> &nums, int target) {
        // hash table
        // TC:O(n); SC:O(n)
        if(nums.size() < 2) {
            return 0;
        }
        int res = 0;
        unordered_map<int, int> hashTable;
        for(int num : nums) {
            hashTable[num]++;
        }
        
        for(auto pair : hashTable) {
            int toFind = target - pair.first;
            if(hashTable.find(toFind) != hashTable.end()) {
                if(hashTable[toFind] > 1 || toFind != pair.first && hashTable[toFind] != -1 && hashTable[pair.first] != -1) {
                    res++;
                    hashTable[toFind] = -1; // to softly remove the val from hashTable
                    hashTable[pair.first] = -1;
                }
            }
        }
        return res;
    }
};