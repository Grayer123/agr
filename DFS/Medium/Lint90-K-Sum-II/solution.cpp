class Solution {
public:
    /*
     * @param A: an integer array
     * @param k: a postive integer <= length(A)
     * @param target: an integer
     * @return: A list of lists of integer
     */
    vector<vector<int>> kSumII(vector<int> &nums, int k, int target) {
        // dfs; backtracking;
		// tc:O(n! * n); sc:O(n)
		if (nums.empty()){//corner case
			return{};
		}
		vector<vector<int>> res;
		vector<int> path;
		int sum = 0;
		int count = 0;
		dfs(res, path, nums, 0, count, k, sum, target);
		return res;
	}
private:
	void dfs(vector<vector<int>>& res, vector<int>& path, const vector<int> &nums, int pos, int& count, int k, int& sum, int target){
		if (pos >= nums.size() || count >= k){
		    if(count == k && sum == target) {
			    res.push_back(path);
		    }
			return;
		}
		for (int i = pos; i < nums.size(); i++){
			sum += nums[i];
			count++;
			path.push_back(nums[i]);
			dfs(res, path, nums, i + 1, count, k, sum, target); // i + 1 move to next elem
			path.pop_back(); // backtracking
			count--;
			sum -= nums[i]; // backtracking
		}
	}

};