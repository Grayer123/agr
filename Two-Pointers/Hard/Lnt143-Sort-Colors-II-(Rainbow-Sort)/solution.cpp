class Solution {
public:
    void sortColors2(vector<int> &colors, int k) {
        // rainbow sort
        // tc:O(nlogk); sc:O(1)
        if(colors.size() < k) {
            return;
        }
        rainbowSort(colors, 0, colors.size() - 1, 1, k);
        
    }
private:
    void rainbowSort(vector<int>& colors, int start, int end, int colorFrom, int colorTo) {
        if(start >= end || colorFrom >= colorTo) {
            return;
        }
        int colorMid = colorFrom + (colorTo - colorFrom) / 2; // T(k) = 2T(k/2) + O(n)
        int left = start, right = end;
        while(left <= right) {
            while(left <= right && colors[left] <= colorMid) { // divide exactly to two part [<= colorMid, >colorMod]
                left++;
            }
            while(left <= right && colors[right] > colorMid) {
                right--;
            }
            if(left <= right) {
                swap(colors[left], colors[right]);
                left++;
                right--;
            }
        }
        rainbowSort(colors, start, right, colorFrom, colorMid);
        rainbowSort(colors, left, end, colorMid + 1, colorTo);
    }
};