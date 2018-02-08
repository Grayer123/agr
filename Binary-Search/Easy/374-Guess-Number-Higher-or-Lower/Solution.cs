// Forward declaration of guess API.
// @param num, your guess
// @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
int guess(int num);

class Solution {
    public int guessNumber(int n) {
        if(n < 1){ //corner case
            throw std::invalid_argument( "Invalid arguments" );
        }
        int start = 1, end = n;
        while(start + 1 < end){
            int mid = start + (end - start) / 2;
            int res = guess(mid);
            if(res == 0){
                return mid;
            }
            else if(res < 0){
                end = mid;
            }
            else{
                start = mid;
            }
        }
        if(guess(start) == 0){
            return start;
        }
        else{
            return end;
        }
    }
};