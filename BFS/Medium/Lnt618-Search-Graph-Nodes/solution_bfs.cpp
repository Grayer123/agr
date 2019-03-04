/**
 * Definition for Undirected graph.
 * struct UndirectedGraphNode {
 *     int label;
 *     vector<UndirectedGraphNode *> neighbors;
 *     UndirectedGraphNode(int x) : label(x) {};
 * };
 */


class Solution {
public:
    /*
     * @param graph: a list of Undirected graph node
     * @param values: a hash mapping, <UndirectedGraphNode, (int)value>
     * @param node: an Undirected graph node
     * @param target: An integer
     * @return: a node
     */
     UndirectedGraphNode* searchNode(vector<UndirectedGraphNode*>& graph,
                                    map<UndirectedGraphNode*, int>& values,
                                    UndirectedGraphNode* node,
                                    int target) {
        // bfs level order traversal
        // tc:O(n*m); sc:O(n*m)
        if(graph.size() == 0) {
            return nullptr;
        }
        unordered_set<UndirectedGraphNode*> visited;
        queue<UndirectedGraphNode*> q;
        q.push(node);
        while(!q.empty()) {
            int levelSize = q.size();
            UndirectedGraphNode* nd = q.front();
            q.pop();
            if(values[nd] == target) {
                return nd;
            }
            visited.insert(nd);
            for(auto ngb : nd->neighbors) {
                if(visited.find(ngb) == visited.end()) {
                    q.push(ngb);
                }
            }
        }
        return nullptr;
        
    }
};