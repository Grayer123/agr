// public class Timestamp {
//     public int id; 
//     public int start;
//     public int end;
//     public Timestamp(int id, int s, int e) {
//         this.id = id;
//         this.start = s;
//         this.end = e;
//     }
// }

public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        // stack
        // tc:O(n); sc:O(n)
        if(n == 0) {
            return new int[0];
        } 
        int[] res = new int[n];
        Stack<int> stack = new Stack<int>();
        int lastTimestamp = 0;
        foreach(string log in logs) {
            var arr = log.Split(':');
            int id = Int32.Parse(arr[0]);
            string status = arr[1];
            int time = Int32.Parse(arr[2]);
            if(stack.Count == 0) { // stack empty
                stack.Push(id);
                lastTimestamp = time;
            }
            else if(status == "start") {
                res[stack.Peek()] += time - lastTimestamp; // for last timestamp
                stack.Push(id);
                lastTimestamp = time;
            }
            else { // status == "end"
                res[stack.Peek()] += time - lastTimestamp + 1;
                stack.Pop();
                lastTimestamp = time + 1;
            }
        }
        return res;
    }
}