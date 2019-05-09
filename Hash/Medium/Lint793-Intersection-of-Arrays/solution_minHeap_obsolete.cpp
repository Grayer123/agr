class Elem {
public:
    int row;
    int col;
    vector<vector<int>> arrs;
    Elem(int r, int c, vector<vector<int>>& ars): row(r), col(c), arrs(ars){}
};

class CompareElem {
public:
    bool operator()(Elem e1, Elem e2) {
        return e1.arrs[e1.row][e1.col] >= e2.arrs[e2.row][e2.col]; // minHeap 
    }
};

class Solution {
public:
    /**
     * @param arrs: the arrays
     * @return: the number of the intersection of the arrays
     */
    int intersectionOfArrays(vector<vector<int>> &arrs) {
        // sort + priority queue 
        // tc:O(knlogn + nklogk); sc:O(k)
        if(arrs.size() == 0) {
            return 0;
        }
        priority_queue<Elem, vector<Elem>, CompareElem> minHeap;
        for(int i = 0; i < arrs.size(); i++) {
            if(arrs[i].size() == 0) { // corner case 
                return 0;
            }
            sort(arrs[i].begin(), arrs[i].end());
            minHeap.push(Elem(i, 0, arrs));
        }
        int lastElem = 0, count = 0;
        int res = 0;
        while(!minHeap.empty()) {
            auto elem = minHeap.top();
            minHeap.pop();
            if(count == 0 || arrs[elem.row][elem.col] == lastElem) {
                count++;
                
                lastElem = arrs[elem.row][elem.col];
                if(count == arrs.size()) {
                    res++;
                }
            }
            else {
                count = 1;
                lastElem = arrs[elem.row][elem.col];
            }
            if(elem.col + 1 < arrs[elem.row].size()) {
                minHeap.push(Elem(elem.row, elem.col + 1, arrs));
            }
        }
        return res;
    }
};