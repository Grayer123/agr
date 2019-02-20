class Solution {
public:
    /*
     * @param graph: A list of Directed graph node
     * @return: Any topological order for the given graph.
     */
    vector<DirectedGraphNode*> topSort(vector<DirectedGraphNode*>& graph) {
        // bfs + hash table
	   //TC:O(m*n); SC:O(n)
        if(graph.size() == 0) {
            return {};
        }
        unordered_map<DirectedGraphNode*, int> dict;
        vector<DirectedGraphNode*> res;
        queue<DirectedGraphNode*> q;
        for(auto node : graph) { // note all the nodes with in-dgree >= 1
            for(auto nd : node->neighbors) {
                dict[nd] = dict.find(nd) != dict.end() ? ++dict[nd] : 1;
            }
        }
        for(auto node: graph) {
            if(dict.find(node) == dict.end()) { // find all nodes with in-dgree = 0
                q.push(node); // add to queue
            }
        }
        while(!q.empty()) {
            auto node = q.front();
            q.pop();
            res.push_back(node);
            for(auto nd : node->neighbors) {
                dict[nd]--;  // has been accessed, in-degree--
                if(dict[nd] == 0) { // in-degree = 0 => add to the queue
                    q.push(nd);
                }
            }
        }
        return res;
    }
};
