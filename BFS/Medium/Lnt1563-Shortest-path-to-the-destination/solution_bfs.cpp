class Solution {
public:
    /**
     * @param targetMap: 
     * @return: nothing
     */
    int shortestPath(vector<vector<int>> &targetMap) {
        // bfs
        // tc:O(n^2); sc:O(n)
        if(targetMap.size() == 0) {
            return 0;
        }
        queue<pair<int, int>> que;
        que.push(make_pair(0, 0));
        targetMap[0][0] = 1; // update the graph to unreachable
        int count = 0;
        while(que.size() > 0) {
            int rowSize = que.size();
            count++;
            for(int i = 0; i < rowSize; i++) {
                auto node = que.front();
                que.pop();
                int dx[] = {1, -1, 0, 0};
                int dy[] = {0, 0, 1, -1};
                for(int j = 0; j < 4; j++) {
                    int row = node.first + dx[j];
                    int col = node.second + dy[j];
                    if(checkBoundary(targetMap, row, col)) {
                        if(targetMap[row][col] == 2) { // find the target
                            return count;
                        }
                        if(targetMap[row][col] == 0) {
                            que.push(make_pair(row, col));
                            targetMap[row][col] = 1; // update the graph to unreachable
                        }
                    }
                }
            }
        }
        return -1; // cannot find any solution
    }
    
private:
    bool checkBoundary(vector<vector<int>>& targetMap, int row, int col) {
        return row >= 0 && row < targetMap.size() && col >= 0 && col < targetMap[0].size();
    }
};