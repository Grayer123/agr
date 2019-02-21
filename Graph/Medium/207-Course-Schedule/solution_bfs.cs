public class Solution {
    public bool CanFinish(int numCourses, int[,] prerequisites) {
        // bfs + hash table
        // tc:O(mn); sc:O(n)
        if(numCourses == 0 || prerequisites == null || prerequisites.Length == 0) {
            return true;
        }
        Dictionary<int, int> dict = new Dictionary<int, int>(); // record all the in-degree of node
        Dictionary<int, IList<int>> graph = new Dictionary<int, IList<int>>(); // build the node with edges
        Queue<int> queue = new Queue<int>();
        int sum = 0;
        for(int i = 0; i < prerequisites.GetLength(0); i++) {
            dict[prerequisites[i,0]] = dict.ContainsKey(prerequisites[i,0]) ? ++dict[prerequisites[i,0]] : 1; // calculate in-dgree
            if(graph.ContainsKey(prerequisites[i,1])) { //build the graph
                graph[prerequisites[i,1]].Add(prerequisites[i,0]);
            }
            else {
                graph[prerequisites[i,1]] = new List<int>{prerequisites[i,0]}; 
            }
        }     
        for(int i = 0; i < numCourses; i++) { // find all node with in-degree = 0
            if(!dict.ContainsKey(i)) {
                queue.Enqueue(i); // push to queue
            }
        }
        while(queue.Count > 0) {
            int node = queue.Dequeue();
            sum++;
            if(graph.ContainsKey(node)){
                foreach(var course in graph[node]) {
                    dict[course]--;
                    if(dict[course] == 0) {
                        queue.Enqueue(course);
                    }
                }
            }
        }
        return sum == numCourses;
    }
}