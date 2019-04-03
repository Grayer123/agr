class Solution {
public:
    /**
     * @param candidates: A list of integers
     * @param target: An integer
     * @return: A list of lists of integers
     */
    vector<vector<int>> combinationSum(vector<int> &candidates, int target) {
		// dfs; backtracking;
		// TC:O(n!); SC:O(n)
		if (candidates.empty() || target < 1){//corner case
			return{};
		}
		sort(candidates.begin(), candidates.end()); // allow duplicate nums => need to sort first to align duplicates together
		vector<vector<int>> res;
		vector<int> path;
		int sum = 0;
		dfs(res, path, candidates, 0, sum, target);
		return res;
	}
private:
	void dfs(vector<vector<int>>& res, vector<int>& path, const vector<int> &cand, int pos, int& sum, int target){
		if (sum >= target || pos >= cand.size()){
		    if(sum == target) {
			    res.push_back(path);
		    }
			return;
		}
		for (int i = pos; i < cand.size(); i++){
			if (i > 0 && cand[i] == cand[i - 1]){ // each num could be used unlimited time, so skip duplicate elems directly
				continue;
			}
			sum += cand[i];
			path.push_back(cand[i]);
			dfs(res, path, cand, i, sum, target); //still i due to repeat
			path.pop_back(); // backtracking
			sum -= cand[i]; // backtracking
		}
	}

};
