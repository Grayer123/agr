public class Solution {
    public void Solve(char[,] board) {
        // dfs 
        // tc:O(n^2); sc:O(n^2)
        if(board == null) {
            return;
        }
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        CheckBoundaries(board, queue);
        Dfs(board, queue);
        SetToX(board);
    }
    
    private void CheckBoundaries(char[,] board, Queue<Tuple<int, int>> queue) {
        int m = board.GetLength(0), n = board.GetLength(1);
        for(int i = 0; i < m; i++) {
            if(board[i, 0] == 'O') {
                queue.Enqueue(new Tuple<int, int>(i, 0));
            }
            if(board[i, n - 1] == 'O') {
                queue.Enqueue(new Tuple<int, int>(i , n - 1));
            }
        }
        for(int j = 0; j < n; j++) {
            if(board[0, j] == 'O') {
                queue.Enqueue(new Tuple<int, int>(0, j));
            }
            if(board[m  - 1, j] == 'O') {
                queue.Enqueue(new Tuple<int, int>(m - 1, j));
            }
        }
    }
    
    private void Dfs(char[,] board, Queue<Tuple<int, int>> queue) {    
        if(queue.Count == 0) {
            return;
        }
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};
        var tuple = queue.Dequeue();
        board[tuple.Item1, tuple.Item2] = 'B';
        for(int i = 0; i < 4; i++) {
            int x = tuple.Item1 + dx[i];
            int y = tuple.Item2 + dy[i];
            if(IsValid(board, x , y) && board[x, y] == 'O') {
                queue.Enqueue(new Tuple<int, int>(x, y));
            }
        }
        Dfs(board, queue);
    }
    
    private bool IsValid(char[,] board, int x, int y) {
        return x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1);
    }
    
    
    private void SetToX(char[,] board) {
        for(int i = 0; i < board.GetLength(0); i++) {
            for(int j = 0; j < board.GetLength(1); j++) {
                if(board[i, j] == 'B') { // boundary node, mark back to 'O'
                    board[i, j] = 'O';
                }
                else if(board[i, j] == 'O') { // surrounded node => mark to 'X'
                    board[i, j] = 'X';
                }
            }
        }
    }
    
    
}