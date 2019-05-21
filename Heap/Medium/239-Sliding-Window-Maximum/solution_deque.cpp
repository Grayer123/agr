class Solution {
public:
    vector<int> maxSlidingWindow(vector<int>& nums, int k) {
        // deque
        // tc:O(n); sc:O(k)
        if(nums.size() == 0 || nums.size() < k) {
            return {};
        }
        // vector<int> res(nums.size() - k);
        vector<int> res;
        deque<int> que;
        
        for(int i = 0; i < k - 1; i++) { // to initialize deque with (k -1) nums
            enqueue(que, nums[i]);
        }
        for(int i = k - 1; i < nums.size(); i++) {
            enqueue(que, nums[i]);
            res.push_back(que.front());
            dequeue(que, nums[i - k + 1]);  // try to remove the leftmost num in window (window passing)
        }
        return res;
    }

private:
    void enqueue(deque<int>& que, int num) {
        while(que.size() > 0 && que.back() < num) { // elems in deque smaller than num, remove from back
            que.pop_back();
        }
        que.push_back(num);
    }
    
    void dequeue(deque<int>& que, int num) {
        if(que.size() > 0 && que.front() == num) { // window passing, remove num from front
            que.pop_front();
        }
    }
};