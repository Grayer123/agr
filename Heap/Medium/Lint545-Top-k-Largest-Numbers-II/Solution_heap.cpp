class Solution {
public:
    /*
    * @param k: An integer
    */Solution(int k) {
        // do intialization if necessary
        count = k;
    }

    /*
     * @param num: Number to be added
     * @return: nothing
     */
    void add(int num) {
        // tc:O(logk)
        minHeap.push(num);
        if(minHeap.size() > count) { // maintain size count minHeap
            minHeap.pop();
        }
    }

    /*
     * @return: Top k element
     */
    vector<int> topk() {
        // tc:O(klogk)
        auto heap = minHeap;
        vector<int> res(minHeap.size());
        int pos = minHeap.size() - 1;
        while(heap.size() > 0) {
            res[pos--] = heap.top();
            heap.pop();
        }
        return res;
    }
    
private: 
    priority_queue<int, vector<int>, greater<int>> minHeap;
    int count;
};