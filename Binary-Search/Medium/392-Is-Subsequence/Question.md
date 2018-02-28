# 392. Is Subsequence

[Original Page](https://leetcode.com/problems/is-subsequence/description/)

Given a string `s` and a string `t`, check if `s` is subsequence of `t`.

You may assume that there is only lower case English letters in both s and t. 
`t` is potentially a very `long (length ~= 500,000)` string, and `s` is a `short (<=100)` string.

A subsequence of a string is a new string which is formed from the original string 
by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. 
(ie, `"ace"` is a subsequence of `"abcde"` while `"aec"` is not).

**Example 1:**

s = `"abc"`, t = `"ahbgdc"`

Return `true`.


**Example 2:**

s = `"axc"`, t = `"ahbgdc"`

Return `false`.
---------------------------------------------------------------------------------------

**Follow Up:**

If there are `lots of` incoming S, say S1, S2, ... , Sk where `k >= 1B`, 
and you want to check one by one to see if T has its subsequence. 
In this scenario, how would you change your code?

---


* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [Pinterest](https://leetcode.com/company/pinterest/)
* Related Topics: *[Two-Pointers](https://leetcode.com/tag/two-pointers/) *[Binary Search](https://leetcode.com/tag/binary-search/) *[Dynamic Programming](https://leetcode.com/tag/dynamic-programming/) *[Greedy](https://leetcode.com/tag/greedy/)