# 80. Remove Duplicates from Sorted Array II

[Original Page](https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/)

Follow up for `"Remove Duplicates"`:
What if duplicates are allowed at most twice?

Given a sorted array nums, remove the duplicates in-place such that duplicates appeared at most twice and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

**Example:** 
```
Example 1:

Given nums = [1,1,1,2,2,3],

Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.

It doesn't matter what you leave beyond the returned length.


Example 2:

Given nums = [0,0,1,1,1,1,2,3,3],

Your function should return length = 7, with the first seven elements of nums being modified to 0, 0, 1, 1, 2, 3 and 3 respectively.

It doesn't matter what values are set beyond the returned length.


Clarification:

Confused why the returned value is an integer but your answer is an array?

Note that the input array is passed in by reference, which means modification to the input array will be known to the caller as well.

Internally you can think of this:

// nums is passed in by reference. (i.e., without making a copy)
int len = removeDuplicates(nums);

// any modification to nums in your function would be known by the caller.
// using the length returned by your function, it prints the first len elements.
for (int i = 0; i < len; i++) {
    print(nums[i]);
}
```
Original Question: [(E) 26. Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/):
Given a **sorted** array, remove the `duplicates` **in-place** such that each element appear only once and return the new length.
**Do not** allocate extra space for another array, you must do this by `modifying the input array` **in-place** with `O(1)` extra memory.
 
---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=medium)
* Companies *[Facebook](https://leetcode.com/company/facebook/) *[Microsoft](https://leetcode.com/company/microsoft/) *[Bloomberg](https://leetcode.com/company/bloomberg/) *[Baidu](https://leetcode.com/company/baidu/)
* Related Topics * [Array](https://leetcode.com/tag/array/)  * [Two Pointers](https://leetcode.com/tag/two-pointers/)
* Similar Questions 
  * [(E) 27. Remove Element](https://leetcode.com/problems/remove-element/description/)
