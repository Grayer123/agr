/*
 * @lc app=leetcode id=371 lang=csharp
 *
 * [371] Sum of Two Integers

 Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.

Example 1:
Input: a = 1, b = 2
Output: 3

Example 2:
Input: a = -2, b = 3
Output: 1
 */
public class Solution {
    public int GetSum(int a, int b) {
        // bit manipulation
        // tc:O(n); sc:O(1)
        if(a == 0) {
            return b;
        }
        if(b == 0) {
            return a;
        }
        if((a & b) == 0) { // no carry exists
            return a | b;
        }
        int a_ = a ^ b;  // xor => no carry addition
        int b_ = a & b;  // get all the pos (both have 1)
        b_ <<= 1;  // mimic carry forward
        return GetSum(a_, b_);  // next step is to do a_ + b_
    }
}

