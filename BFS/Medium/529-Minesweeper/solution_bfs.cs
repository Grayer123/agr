public class Solution {
    public char[,] UpdateBoard(char[,] board, int[] click) {
        // bfs + 8 directional matrix
        // tc:O(mn); sc:O(n)
        if(board == null || board.GetLength(0) == 0) {
            return board;
        }
        int x = click[0], y = click[1];
        if(board[x, y] == 'M') {
            board[x, y] = 'X';
            return board;
        }
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(new Tuple<int, int>(x, y));
        Bfs(board, queue);
        return board;
    }
    private void Bfs(char[,] board, Queue<Tuple<int, int>> queue) {
        int[] dx = {1, -1, 0, 0, 1, 1, -1, -1}; // 8 direction
        int[] dy = {0, 0, 1, -1, 1, -1, 1, -1};
        while(queue.Count > 0) {
            var node = queue.Dequeue();
            int x = node.Item1, y = node.Item2;
            int mines = 0;
            List<Tuple<int, int>> nexts = new List<Tuple<int, int>>();
            for(int i = 0; i < 8; i++) {
                int newX = x + dx[i];
                int newY = y + dy[i];
                if(IsValid(board, newX, newY)) {
                    if(board[newX, newY] == 'M') {
                        mines++;
                    }
                    else if(board[newX, newY] == 'E') {
                        nexts.Add(new Tuple<int, int>(newX, newY));
                    }
                }
            }
            if(mines != 0) {
                board[x, y] = (char)('0' + mines);
            }
            else {
                board[x, y] = 'B';
                foreach(var tuple in nexts) {
                    queue.Enqueue(Tuple.Create(tuple.Item1, tuple.Item2));
                }
            }
        }
        
    }
    private bool IsValid(char[,] board, int x, int y) {
        return x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1);
    }
}