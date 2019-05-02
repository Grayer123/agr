/*
 * @lc app=leetcode id=338 lang=csharp
 *
 * [338] Counting Bits
 Tags
bit-manipulation | dynamic-programming

Companies
Unknown

Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

Example 1:

Input: 2
Output: [0,1,1]
Example 2:

Input: 5
Output: [0,1,1,2,1,2]
Follow up:

It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
Space complexity should be O(n).
Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.
 */
public class Solution {
    public int[] CountBits(int num) {
        // bit manipulation
        // tc:O(nk)=> for each x, we need O(k) operations where k is the number of bits in x.; sc:O(1)
        if(num < 0) {
            return new int[0];
        }
        int[] res = new int[num + 1];
        for(uint i = 0; i <= num; i++) {
            res[i] = HammingWeight(i);
        }
        return res;
    }
    private int HammingWeight(uint n) {
        // bit manipulation 
        // tc:O(n) => n is the count of 1 in n; sc:O(1)
        int count = 0;
        while(n != 0) {
            n &= n - 1; // every time eliminate the least significant 1
            count++;
        }
        return count;
    }
}

