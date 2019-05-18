public class Solution {
    public int NumIslands(char[][] grid) {
        // dfs + reuse the original array
        // tc:O(n^2); sc:O(1)
        if(grid == null || grid.Length == 0) {
            return 0;
        }
        int count = 0;
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == '1') {
                    DfsTraversal(grid, i, j);
                    count++;
                }
            }
        }
        return count;
    }
    
    private void DfsTraversal(char[][] grid, int row, int col) {
        grid[row][col] = 'x'; // mark the elem has been visited
        int[] dx = new int[] {1, -1, 0, 0};
        int[] dy = new int[] {0, 0, 1, -1};
        for(int i = 0; i < 4; i++) { // visit 4 directions
            int newRow = row + dx[i];
            int newCol = col + dy[i];
            if(CheckBoundary(grid, newRow, newCol) && grid[newRow][newCol] == '1') {
                DfsTraversal(grid, newRow, newCol);
            }
        }
    }
    
    private bool CheckBoundary(char[][] grid, int row, int col) {
        return row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length;
    }
}