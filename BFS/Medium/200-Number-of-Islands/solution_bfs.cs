public class Solution {
    public int NumIslands(char[][] grid) {
        // bfs + reuse the original array
        // tc:O(n*m); sc:O(n*m)
        if(grid == null || grid.Length == 0) {
            return 0;
        }
        int count = 0;
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == '1') {
                    grid[i][j] = 'x';  // mark as visited
                    queue.Enqueue(new Tuple<int, int>(i, j));
                    BfsTraversal(grid, queue);
                    count++;
                }
            }
        }
        return count;
    }
    
    private void BfsTraversal(char[][] grid, Queue<Tuple<int, int>> queue) {        
        int[] dx = new int[] {1, -1, 0, 0};  // x direction -> horizontal 
        int[] dy = new int[] {0, 0, 1, -1};  // y direction -> vertical
        while(queue.Count > 0) {
            var node = queue.Dequeue();
            for(int i = 0; i < 4; i++) { // visit 4 directions
                int newRow = node.Item1 + dx[i];
                int newCol = node.Item2 + dy[i];
                if(CheckBoundary(grid, newRow, newCol) && grid[newRow][newCol] == '1') {
                    grid[newRow][newCol] = 'x'; // mark the elem has been visited
                    queue.Enqueue(new Tuple<int, int>(newRow, newCol));
                }
            }
        }
    }
    
    private bool CheckBoundary(char[][] grid, int row, int col) {
        return row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length;
    }
}