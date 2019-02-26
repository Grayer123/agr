public class Solution {
    public int NumIslands(char[,] grid) {
        // dfs 
        // tc:O(n*m); sc:O(n*m)
        if(grid == null) {
            return 0;
        }
        int res = 0;
        for(int i = 0; i < grid.GetLength(0); i++) {
            for(int j = 0; j < grid.GetLength(1); j++) {
                if(grid[i,j] == '1') {
                    Dfs(i, j, grid);
                    res++;
                }
            }
        }
        return res;
    }
    
    private void Dfs(int x, int y, char[,] grid) {
        grid[x, y] = 'v';
        int[] dx = {1, -1, 0, 0}; // x direction -> horizontal 
        int[] dy = {0, 0, 1, -1}; // y direction -> vertical
        
        for(int i = 0; i < 4; i++) { // 4 direction
            int newX = x + dx[i];
            int newY =  y + dy[i];
            if(IsValid(newX, newY, grid) && grid[newX, newY] == '1') {
                Dfs(newX, newY, grid);
            }
        }
    }
    
    private bool IsValid(int x, int y, char[,] grid) {
        return x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1);
    }
}