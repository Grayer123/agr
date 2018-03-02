struct Elem {
    int val;
    int x;
    int y;
    Elem(int v, int xx, int yy): val(v), x(xx), y(yy){}
};

class CompareElem {
public:
    bool operator()(Elem* elem1, Elem* elem2){
        return elem1->val >= elem2->val; //returns min-heap
    }
};

class Solution {
public:
    vector<pair<int, int>> kSmallestPairs(vector<int>& nums1, vector<int>& nums2, int k) {
        if(nums1.empty() || nums2.empty() || k < 0){
            return vector<pair<int, int>>();
        }
        vector<pair<int, int>> res;
        priority_queue<Elem*, vector<Elem*>, CompareElem> heap;
        
        for(int i = 0; i < nums2.size(); i++){ //combine nums1[0] with nums2[0 ~ n] 
            heap.push(new Elem(nums1[0] + nums2[i], 0, i));
        }
        
        int cnt = 0, m = nums1.size(), n = nums2.size();
        while(cnt < min(m * n, k)){
            Elem* elem = heap.top();
            heap.pop();
            int x = elem->x, y = elem->y;
            res.push_back(pair<int, int>(nums1[x], nums2[y]));
            cnt++;
            if(x == m - 1){
                continue;
            }
            heap.push(new Elem(nums1[x + 1] + nums2[y], x + 1, y));
        }
        return res;
    }
};