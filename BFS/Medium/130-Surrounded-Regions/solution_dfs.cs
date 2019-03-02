public class Solution {
    public void Solve(char[,] board) {
        // dfs 
        // tc:O(n^2); sc:O(n^2)
        if(board == null) {
            return;
        }
        CheckBoundaries(board);
        SetToX(board);
    }
    
    private void CheckBoundaries(char[,] board) {
        int m = board.GetLength(0), n = board.GetLength(1);
        for(int i = 0; i < m; i++) {
            if(board[i, 0] == 'O') {
                Dfs(board, i, 0);
            }
            if(board[i, n - 1] == 'O') {
                Dfs(board, i , n - 1);
            }
        }
        for(int j = 0; j < n; j++) {
            if(board[0, j] == 'O') {
                Dfs(board, 0, j);
            }
            if(board[m  - 1, j] == 'O') {
                Dfs(board, m - 1, j);
            }
        }
    }
    
    private void Dfs(char[,] board, int x, int y) {    
        board[x, y] = 'B';
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};        
        for(int i = 0; i < 4; i++) {
            int newX = x + dx[i];
            int newY = y + dy[i];
            if(IsValid(board, newX, newY) && board[newX, newY] == 'O') {
                Dfs(board, newX, newY);
            }
        }
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