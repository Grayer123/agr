class Solution {

    class Elem {
    public:
        int row;
        int col;
    };

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
        auto comp = [&arrs](const Elem* e1, const Elem* e2) -> bool {
            return arrs[e1->row][e1->col] >= arrs[e2->row][e2->col];
        };

        priority_queue<Elem*, vector<Elem*>, decltype(comp)> minHeap(comp);

        for(int i = 0; i < arrs.size(); i++) {
            if(arrs[i].size() == 0) { // corner case
                return 0;
            }
            sort(arrs[i].begin(), arrs[i].end());
            minHeap.push(new Elem{i, 0});
        }
        int lastElem = 0, count = 0;
        int res = 0;
        while(!minHeap.empty()) {
            auto elem = minHeap.top();
            minHeap.pop();
            if(count == 0 || arrs[elem->row][elem->col] == lastElem) {
                count++;

                lastElem = arrs[elem->row][elem->col];
                if(count == arrs.size()) {
                    res++;
                }
            }
            else {
                count = 1;
                lastElem = arrs[elem->row][elem->col];
            }
            if(elem->col + 1 < arrs[elem->row].size()) {
                minHeap.push(new Elem{ elem->row, elem->col + 1 });
            }
        }
        return res;
    }
};