public class Solution {
    public void Solve(char[,] board) {
        // bfs 
        // tc:O(n^2); sc:O(n^2)
        if(board == null) {
            return;
        }
        bool[,] visited = new bool[board.GetLength(0), board.GetLength(1)];
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        for(int i = 0; i < board.GetLength(0); i++) {
            for(int j = 0; j < board.GetLength(1); j++) {
                List<Tuple<int, int>> list = new List<Tuple<int, int>>();
                if(board[i, j] == 'O' && !visited[i ,j]) {
                    queue.Enqueue(new Tuple<int, int>(i, j));
                    list.Add(new Tuple<int, int>(i, j));
                    if(!Bfs(board, visited, queue, list)) {
                        SetToX(board, list);
                    }
                }
            }
        }
    }
    private bool Bfs(char[,] board, bool[,] visited, Queue<Tuple<int, int>> queue, List<Tuple<int, int>> list) {      
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};
        bool flag = false;
        while(queue.Count > 0) {
            var tuple = queue.Dequeue();
            if(IsBoarder(board, tuple)) {
                flag = true;
            }
            for(int i = 0; i < 4; i++) {
                int x = tuple.Item1 + dx[i];
                int y = tuple.Item2 + dy[i];
                if(IsValid(board, x , y) && board[x, y] == 'O' && !visited[x, y]) {
                    queue.Enqueue(new Tuple<int, int>(x, y));
                    visited[x, y] = true;
                    list.Add(new Tuple<int, int>(x, y));
                }
            }
        }
        return flag;
    }
    
    private bool IsValid(char[,] board, int x, int y) {
        return x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1);
    }
    
    private bool IsBoarder(char[,] board, Tuple<int, int> tuple) {
        return tuple.Item1 == 0 || tuple.Item1 == board.GetLength(0) - 1 || tuple.Item2 == 0 || tuple.Item2 == board.GetLength(1) - 1;
    }
    
    private void SetToX(char[,] board, List<Tuple<int, int>> list) {
        foreach(var tuple in list) {
            board[tuple.Item1, tuple.Item2] = 'X';
        }
    }
    
    
}