public class Solution {
    public int[,] UpdateMatrix(int[,] matrix) {
        // bfs on matrix
        // tc:O(mn); sc:O(n)
        if(matrix == null || matrix.GetLength(0) == 0) {
            return new int[0, 0];
        }
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        for(int i = 0; i < matrix.GetLength(0); i++) {
            for(int j = 0; j < matrix.GetLength(1); j++) {
                matrix[i, j] = matrix[i, j] == 1 ? Int32.MaxValue : 0; 
                if(matrix[i, j] == 0) {
                    queue.Enqueue(new Tuple<int, int>(i, j));
                }
            }
        }
        Bfs(matrix, queue);
        return matrix;
    }
    private void Bfs(int[,] matrix, Queue<Tuple<int, int>>queue) {
        int[] dx = {1, -1, 0 ,0};
        int[] dy = {0, 0, 1, -1};
        while(queue.Count > 0) {
            var pair = queue.Dequeue();
            int x = pair.Item1, y = pair.Item2;
            for(int i = 0; i < 4; i++) {
                int newX = x + dx[i];
                int newY = y + dy[i];
                if(IsValid(matrix, newX, newY) && matrix[newX, newY] > matrix[x, y] + 1) {
                    matrix[newX, newY] = matrix[x, y] + 1;
                    queue.Enqueue(new Tuple<int, int>(newX, newY));
                }
            }
        }
    }
    
    private bool IsValid(int[,] matrix, int x, int y) {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
    }
}