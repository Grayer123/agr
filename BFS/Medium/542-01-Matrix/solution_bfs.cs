public class Solution {
    public int[,] UpdateMatrix(int[,] matrix) {
        // bfs on matrix
        // tc:O(mn); sc:O(1)
        if(matrix.GetLength(0) == 0) {
            return new int[0, 0];
        }
        int[,] res = new int[matrix.GetLength(0), matrix.GetLength(1)];
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        for(int i = 0; i < matrix.GetLength(0); i++) {
            for(int j = 0; j < matrix.GetLength(1); j++) {
                res[i, j] = matrix[i, j] == 1 ? Int32.MaxValue : 0; 
                if(matrix[i, j] == 0) {
                    queue.Enqueue(new Tuple<int, int>(i, j));
                }
            }
        }
        Bfs(res, queue);
        return res;
    }
    private void Bfs(int[,] res, Queue<Tuple<int, int>>queue) {
        int[] dx = {1, -1, 0 ,0};
        int[] dy = {0, 0, 1, -1};
        while(queue.Count > 0) {
            var pair = queue.Dequeue();
            int x = pair.Item1, y = pair.Item2;
            for(int i = 0; i < 4; i++) {
                int newX = x + dx[i];
                int newY = y + dy[i];
                if(IsValid(res, newX, newY) && res[newX, newY] > res[x, y] + 1) {
                    res[newX, newY] = res[x, y] + 1;
                    queue.Enqueue(new Tuple<int, int>(newX, newY));
                }
            }
        }
    }
    
    private bool IsValid(int[,] res, int x, int y) {
        return x >= 0 && x < res.GetLength(0) && y >= 0 && y < res.GetLength(1);
    }
}