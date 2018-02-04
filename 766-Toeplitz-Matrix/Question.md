# 766. Toeplitz Matrix

[Original Page](https://leetcode.com/problems/toeplitz-matrix/description/)

A matrix is Toeplitz if every diagonal from top-left to bottom-right has the same element.

Now given an M x N matrix, return True if and only if the matrix is Toeplitz.
 
**Example1:** 
<pre>
Input: matrix = [[1,2,3,4],[5,1,2,3],[9,5,1,2]]
Output: True
Explanation:
1234
5123
9512


In the above grid, the diagonals are "[9]", "[5, 5]", "[1, 1, 1]", "[2, 2, 2]", "[3, 3]", "[4]", and in each diagonal all elements are the same, so the answer is True.
</pre>

**Example2:** 
<pre>
**Input:** matrix = [[1,2],[2,2]]
**Output:** False
Explanation:
The diagonal "[1, 2]" has different elements.
</pre>

Note:
1. matrix will be a 2D array of integers.
2. matrix will have a number of rows and columns in range [1, 20].
3. matrix[i][j] will be integers in range [0, 99].


Difficulty:Easy
Companies 
Google
Related Topics 
Array
Similar Questions 
Valid Word Square

<div>

    <div id="company_tags" class="btn btn-xs btn-warning">Company Tags</div>

    <span class="hidebutton" style="display: inline;">[Google]</span>
</div>

<div>

    <div id="tags" class="btn btn-xs btn-warning">Related Topics</div>

    <span class="hidebutton" style="display: inline;">[Array] [Math](/tag/math/)</span>
</div>

<div>

    <div id="similar" class="btn btn-xs btn-warning">Hide Similar Problems</div>

    <span class="hidebutton" style="display: inline;">[(M) Valid Word Square](/problems/multiply-strings/) </span>
</div>