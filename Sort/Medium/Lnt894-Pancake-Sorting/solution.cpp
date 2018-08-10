/**
 * class FlipTool {
 * public:
 *   static void flip(vector<int>& arr, int i);
 * };
 */
class Solution {
public:
    /**
     * @param array: an integer array
     * @return: nothing
     */
    void pancakeSort(vector<int> &array) {
        if(array.size() == 0) { //corner case
            return;
        }
        int curSize = array.size() - 1;
        while(curSize > 0) {
            int maxIdx = findMax(array, curSize);
            FlipTool::flip(array, maxIdx);
            FlipTool::flip(array, curSize);
            curSize--;
        }
    }
    
private:
    int findMax(vector<int>& array, int endIdx) {
        int max =array[0];
        int index = 0;
        for(int i = 0; i <= endIdx; i++) {
            if(array[i] > max) {
                max = array[i];
                index = i;
            }
        }
        return index;
    }
};