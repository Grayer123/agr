class Solution {
public:
	vector<DirectedGraphNode*> topSort(vector<DirectedGraphNode*> graph) {
		// graph: DFS
		//TC:O(m*n); SC:O(n)
		vector<DirectedGraphNode*> res;
		unordered_map<DirectedGraphNode*, int> hash;
		for (auto node : graph){
			for (auto nd : node->neighbors){
				hash[nd]++;//calculate each node's in-degree
			}
		}
		for (auto nd : graph){
			if (hash.find(nd) == hash.end()){
				dfs(hash, res, nd);
			}
		}
		return res;
	}
private:
	void dfs(unordered_map<DirectedGraphNode*, int>& hash, vector<DirectedGraphNode*>& res, DirectedGraphNode* node){
		res.push_back(node);
		for (auto nd : node->neighbors){
			hash[nd]--;
			if (!hash[nd]){
				dfs(hash, res, nd);
			}
		}
	}
};