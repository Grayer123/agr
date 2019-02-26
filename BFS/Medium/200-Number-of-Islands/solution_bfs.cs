public class Solution {
    public int NumIslands(char[,] grid) {
        // bfs 
        // tc:O(n*m); sc:O(n*m)
        if(grid == null) {
            return 0;
        }
        int res = 0;
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        for(int i = 0; i < grid.GetLength(0); i++) {
            for(int j = 0; j < grid.GetLength(1); j++) {
                if(grid[i,j] == '1') {
                    grid[i, j] = 'v';
                    queue.Enqueue(new Tuple<int, int>(i, j));
                    Bfs(i, j, grid, queue);
                    res++;
                }
            }
        }
        return res;
    }
    
    private void Bfs(int x, int y, char[,] grid, Queue<Tuple<int, int>> queue) {
        int[] dx = {1, -1, 0, 0}; // x direction -> horizontal 
        int[] dy = {0, 0, 1, -1}; // y direction -> vertical
        while(queue.Count > 0) {
            Tuple<int, int> coordinate = queue.Dequeue();
            for(int i = 0; i < 4; i++) { // 4 direction
                int newX = coordinate.Item1 + dx[i];
                int newY =  coordinate.Item2 + dy[i];
                if(IsValid(newX, newY, grid) && grid[newX, newY] == '1') {
                    grid[newX, newY] = 'v';
                    queue.Enqueue(new Tuple<int, int>(newX, newY));
                }
            }
        }
    }
    
    private bool IsValid(int x, int y, char[,] grid) {
        return x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1);
    }
}