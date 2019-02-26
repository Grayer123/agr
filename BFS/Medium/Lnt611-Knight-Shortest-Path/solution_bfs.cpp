/**
 * Definition for a point.
 * struct Point {
 *     int x;
 *     int y;
 *     Point() : x(0), y(0) {}
 *     Point(int a, int b) : x(a), y(b) {}
 * };
 */

class Solution {
public:
    /**
     * @param grid: a chessboard included 0 (false) and 1 (true)
     * @param source: a point
     * @param destination: a point
     * @return: the shortest path 
     */
    int shortestPath(vector<vector<bool>> &grid, Point &source, Point &destination) {
        // bfs 
        // tc:O(n^2); sc:O(n^2)
        if(source.x == destination.x && source.y == destination.y) {
            return 0;
        }
        if(grid.size() == 0) {
            return -1;
        }
        int res = 0;
        queue<Point> q;
        q.push(source);
        while(!q.empty()) {
            int levelSize = q.size();
            for(int i = 0; i < levelSize; i++) {
                Point node = q.front();
                q.pop();
                if(node.x == destination.x && node.y == destination.y) {
                    return res;
                }
                bfs(grid, node.x, node.y, q);
                
            }
            res++;
        }
        return -1;
    }

private:
    void bfs(vector<vector<bool>>& grid, int x, int y, queue<Point>& q) {
        int dx[] = {-1, -1, 1, 1, -2, -2, 2, 2};
        int dy[] = {-2, 2, -2, 2, -1, 1, -1, 1};
        
        for(int i  = 0; i < 8; i++) {
            int newX = x + dx[i];
            int newY = y + dy[i];
            if(isValid(grid, newX, newY) && !grid[newX][newY]) {
                q.push(Point(newX, newY));
                grid[newX][newY] = true;
            }
        }
        
    }
    
    bool isValid(vector<vector<bool>>& grid, int x, int y) {
        return x >= 0 && x < grid.size() && y >= 0 && y < grid[0].size();
    }
};