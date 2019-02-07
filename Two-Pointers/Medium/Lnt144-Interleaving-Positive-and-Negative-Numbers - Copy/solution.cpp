class Solution {
public:
    /*
     * @param chars: The letter array you should sort by Case
     * @return: nothing
     */
    void sortLetters(string &chars) {
        // partition: quick select
        // TC:O(n); SC:O(1)
        if(chars.size() == 0) {
            return;
        }
        int left = 0, right = chars.size() - 1;
        while(left <= right) {
            while(left <= right && chars[left] > 'Z') {
                left++;
            }
            while(left <= right && chars[right] <= 'Z') {
                right--;
            }
            if(left <= right) {
                swap(chars[left], chars[right]);
                left++;
                right--;
            }
        }
    }
};