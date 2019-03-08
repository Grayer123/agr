public class Solution {
    public IList<int[]> PacificAtlantic(int[,] matrix) {
        // bfs 
        // tc:O(mn); sc:O(mn)
        if(matrix.GetLength(0) == 0) {
            return new List<int[]>();
        }
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        List<int[]> res = new List<int[]>();
        
        Queue<int[]> aq = new Queue<int[]>(); // for atlantic
        bool[,] aVisited = new bool[m, n];
        Queue<int[]> pq = new Queue<int[]>(); // for pacific
        bool[,] pVisited = new bool[m, n];
        for(int i = 0; i < m; i++) { // vertical
            aq.Enqueue(new int[]{i, n -1}); // atlantic
            aVisited[i, n - 1] = true;
            pq.Enqueue(new int[]{i, 0}); // pacific
            pVisited[i, 0] = true;
        }
        for(int j = 0; j < n; j++) { // horizontal
            aq.Enqueue(new int[]{m - 1, j}); // atlantic 
            aVisited[m - 1, j] = true;
            pq.Enqueue(new int[]{0, j}); // pacific
            pVisited[0, j] = true;
        }
        Bfs(matrix, aVisited, aq);
        Bfs(matrix, pVisited, pq);
        
        for(int i = 0; i < m; i++) { // last scan, if both true in two visited[] => true
            for(int j = 0; j < n; j++) {
                if(aVisited[i, j] && pVisited[i, j]) {
                    res.Add(new int[]{i, j});
                }
            }
        }
        return res;
    }
    private void Bfs(int[,] matrix, bool[,] visited, Queue<int[]> queue) {
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};
        while(queue.Count > 0) {
            var node = queue.Dequeue();
            int x = node[0], y = node[1];
            for(int i = 0; i < 4; i++) {
                int newX = x + dx[i];
                int newY = y + dy[i];
                if(IsValid(matrix, newX, newY) && !visited[newX, newY] && matrix[x, y] <= matrix[newX, newY]) {
                    visited[newX, newY] = true;
                    queue.Enqueue(new int[]{newX, newY});
                }
            }
            
        }
    }
    private bool IsValid(int[,] matrix, int x, int y) {
        return x >=0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
    }
}