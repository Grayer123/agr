struct Elem{ //user defined
    int x, y, value;
    Elem(int val, int xx, int yy): value(val), x(xx), y(yy){}
};

class CompareElem{ //user defined
public:
    bool operator()(Elem* elem1, Elem* elem2){ //functor
        return elem1->value >= elem2->value; //return a minHeap
    }
};  

class Solution {
public:
    int kthSmallest(vector<vector<int>>& matrix, int k) {
        int n = matrix.size(); //matrix[0].size() => get the size of dimension 1
        priority_queue<Elem*, vector<Elem*>, CompareElem> heap;
        
        for(int i = 0; i < n; i++){
            heap.push(new Elem(matrix[0][i], 0, i));
        }
        int num = 0;
        while(++num < k){
            Elem* elem = heap.top();
            heap.pop();
            int xCur = elem->x;
            int yCur= elem->y;
            if(xCur < n - 1){
                heap.push(new Elem(matrix[xCur + 1][yCur], xCur + 1, yCur));
            }
        }
        return heap.top()->value;
    }
};