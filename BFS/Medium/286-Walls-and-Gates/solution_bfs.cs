public class Solution {
    public void WallsAndGates(int[,] rooms) {
        // bfs + 4 directional matrix 
        // tc:O(mn); sc:O(n)
        if(rooms == null || rooms.GetLength(0) == 0) {
            return;
        }
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        for(int i = 0; i < rooms.GetLength(0); i++) {
            for(int j = 0; j < rooms.GetLength(1); j++) {  // find all the gate and add it to queue
                if(rooms[i, j] == 0) {
                    queue.Enqueue(new Tuple<int, int>(i, j)); 
                }
            }
        }
        Bfs(rooms, queue);
    }
    
    private void Bfs(int[,] rooms, Queue<Tuple<int, int>> queue) {
        while(queue.Count > 0) {
            var node = queue.Dequeue();
            int x = node.Item1, y = node.Item2;
            int[] dx = {1, -1, 0, 0};
            int[] dy = {0, 0, 1, -1};
            for(int i = 0; i < 4; i++) {
                int newX = x + dx[i];
                int newY = y + dy[i];
                if(IsValid(rooms, newX, newY) && rooms[newX, newY] != -1 && rooms[newX, newY] != 0) {
                    if(rooms[newX, newY] == Int32.MaxValue) {
                        rooms[newX, newY] = rooms[x, y] + 1;
                        queue.Enqueue(new Tuple<int, int>(newX, newY));
                    }
                    // else if(rooms[newX, newY] > rooms[x, y] + 1) {
                    //     rooms[newX, newY] =  rooms[x, y] + 1;
                    //     queue.Enqueue(new Tuple<int, int>(newX, newY));
                    // }                   
                }
            }
        }
    }
    
    private bool IsValid(int[,] rooms, int x, int y) {
        return x >= 0 && x < rooms.GetLength(0) && y >= 0 && y < rooms.GetLength(1);
    }
}