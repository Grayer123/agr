public class MyStack {

    /** Initialize your data structure here. */
    public MyStack() {
        queue = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        int count = queue.Count;
        Queue<int> tmp = new Queue<int>();
        while(queue.Count > 0) {
            int node = queue.Dequeue();
            tmp.Enqueue(node);
        }
        queue.Enqueue(x);
        while(tmp.Count > 0) {
            queue.Enqueue(tmp.Dequeue());
        }
        
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        return queue.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
        return queue.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return queue.Count == 0;
    }
    
    private Queue<int> queue;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */