class Solution {
public:
    int findKthLargest(vector<int>& nums, int k) {
        // min heap
        // tc:O(nlogk); sc:O(n)
        if(nums.size() == 0 || k <= 0 || k > nums.size()) {
            throw "Invalid input";
        }
        priority_queue<int, vector<int>, greater<int>> minHeap;
        for(auto num : nums) {
            minHeap.push(num);
            if(minHeap.size() > k) { // maintain size k min heap
                minHeap.pop();
            }
        }
        return minHeap.top();
    }
};