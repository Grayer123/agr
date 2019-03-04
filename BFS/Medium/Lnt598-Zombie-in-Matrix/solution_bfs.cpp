class Solution {
public:
    /**
     * @param grid: a 2D integer grid
     * @return: an integer
     */
    int zombie(vector<vector<int>> &grid) {
        int numPeople = 0;
        queue<pair<int, int>> q; // store the coordinate of zombie
        for(int i = 0; i < grid.size(); i++) {
            for(int j = 0; j < grid[0].size(); j++) {
                if(grid[i][j] == 0) {
                    numPeople++; // calculate how many people
                }
                else if(grid[i][j] == 1) {
                    q.push(make_pair(i, j)); // add zombies to the queue
                }
            }
        }
        int days = 0;
        int dx[] = {1, -1, 0, 0};
        int dy[] = {0, 0, 1, -1};
         
        while(!q.empty()) {
            int levelSize = q.size();
            days++;
            for(int i = 0; i < levelSize; i++) {
                auto node = q.front();
                q.pop();
                int x = node.first;
                int y = node.second;
                for(int j = 0; j < 4; j++) {
                    int newX = x + dx[j];
                    int newY = y + dy[j];
                    if(isValid(grid, newX, newY) && grid[newX][newY] == 0) {
                        numPeople--;
                        grid[newX][newY] = 1; // ture into zombie
                        q.push(make_pair(newX, newY));
                    }
                }
            }
            if(numPeople == 0) {
                return days;
            }
        }
        return -1;
    }
    
    
private:
    bool isValid(vector<vector<int>> &grid, int x, int y) {
        return x >= 0 && x < grid.size() && y >= 0 && y < grid[0].size();
    }
};