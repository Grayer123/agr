public class MovingAverage {

    /** Initialize your data structure here. */
    public MovingAverage(int size) {
        this.windowSize = size;
    }
    
    public double Next(int val) {
        if(queue.Count >= windowSize) {
            sum -= queue.Dequeue();
        }
        sum += val;
        queue.Enqueue(val);
        return sum / queue.Count;
    }
    
    private Queue<int> queue = new Queue<int>();
    private double sum = 0;
    private int windowSize;
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */