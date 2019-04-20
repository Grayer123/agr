class MedianFinder {
public:
    /** initialize your data structure here. */
    MedianFinder() {  
    }
    
    void addNum(int num) {
        minHeap.push(num);
        maxHeap.push(minHeap.top());
        minHeap.pop();
        if(minHeap.size() + 1 < maxHeap.size()) {
            minHeap.push(maxHeap.top());
            maxHeap.pop();
        }
    }
    
    double findMedian() {
        if((maxHeap.size() + minHeap.size()) % 2 == 0) {
            return (double)(maxHeap.top() + minHeap.top()) / 2;
        }
        return maxHeap.top();
    }

private:
    priority_queue<int, vector<int>, less<int>> maxHeap; // to store smaller number (if odd nums => store one more here)
    priority_queue<int, vector<int>, greater<int>> minHeap; // to store larger number
};

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder* obj = new MedianFinder();
 * obj->addNum(num);
 * double param_2 = obj->findMedian();
 */