public class Solution {
    public int aplusb(int a, int b) {
        // bit manipulation
        // tc:O(n); sc:O(1)
        while(b != 0) {
            int a_ = a ^ b; // xor => no carry addition
            int b_ = a & b; // get all the pos (both have 1)
            b_ <<= 1;  // mimic carry forward
            a = a_;  // actually next step is to do a_ + b_
            b = b_;
        }
        return a;
    }
}