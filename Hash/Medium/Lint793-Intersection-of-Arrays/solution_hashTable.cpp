class Solution {
public:
    /**
     * @param arrs: the arrays
     * @return: the number of the intersection of the arrays
     */
    int intersectionOfArrays(vector<vector<int>> &arrs) {
        // hash table
        // tc:O(m*n); sc:O(m*n)
        if(arrs.size() == 0) {
            return 0;
        }
        unordered_map<int, int> dict;
        for(auto arr : arrs) {
            for(auto num : arr) {
                dict[num] = dict.find(num) != dict.end() ? ++dict[num] : 1;
            }
        }
        int res = 0;
        for(auto it = dict.begin(); it != dict.end(); it++) {
            if(it->second == arrs.size()) {
                res++;
            } 
        }
        return res;
    }
};