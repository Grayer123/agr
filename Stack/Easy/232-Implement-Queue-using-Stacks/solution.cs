public class MyQueue {

    /** Initialize your data structure here. */
    public MyQueue() {
        stack = new Stack<int>();
        stackHelper = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        while(stack.Count > 0) {
            stackHelper.Push(stack.Pop());
        }
        stackHelper.Push(x);
        while(stackHelper.Count > 0) {
            stack.Push(stackHelper.Pop());
        }
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        return stack.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        return stack.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return stack.Count == 0;
    }
    
    private Stack<int> stack, stackHelper;
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */