class MedianFinder {
public:
    /** initialize your data structure here. */
    MedianFinder() {
        
    }
    
    void addNum(int num) {
        if(maxHeap.size() == 0) {
            maxHeap.push(num);
            return;
        }
        if(maxHeap.size() > minHeap.size()) {
            if(maxHeap.top() > num) {
                minHeap.push(maxHeap.top());
                maxHeap.pop();
                maxHeap.push(num);
            }
            else {
                minHeap.push(num);
            }
        }
        else { // minHeap.size() == maxHeap.size() => minHeap is not empty
            if(minHeap.top() >= num) {
                maxHeap.push(num);
            }
            else {
                maxHeap.push(minHeap.top());
                minHeap.pop();
                minHeap.push(num);
            }
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