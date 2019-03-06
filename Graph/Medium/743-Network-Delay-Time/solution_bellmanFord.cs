public class Solution {
    public int NetworkDelayTime(int[,] times, int n, int k) {
        // bellman ford
        // tc:O(n * m); sc:O(n)
        if(times == null || times.GetLength(0) == 0) {
            return -1;
        }
        int[] dist = Enumerable.Repeat(-1, n).ToArray(); // keep the distance from k to i (0...n-1)
        dist[k - 1] = 0;  // k to itself
        for(int i = 0; i < n; i++) {  // n nodes
            for(int j = 0; j < times.GetLength(0); j++) { // all the edges
                int source = times[j, 0] - 1;
                int target = times[j, 1] - 1;
                int distance = times[j, 2];
                if(dist[source] == -1) {
                    continue;
                }
                if(dist[target] == -1 || dist[target] > dist[source] + distance) {
                    dist[target] = dist[source] + distance;
                }
            }
        }
        int maxTime = 0;
        foreach(var time in dist) {
            if(time == -1) {
                return -1;
            }
            maxTime = maxTime < time ? time : maxTime;
        }
        return maxTime;
    }
}