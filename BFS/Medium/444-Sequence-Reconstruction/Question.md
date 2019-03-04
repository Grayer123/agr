# 444. Sequence Reconstruction   
[Original Page](https://leetcode.com/problems/sequence-reconstruction/)    

Check whether the original sequence `org` can be `uniquely` reconstructed from the sequences in `seqs`. The org sequence is a permutation of the integers from 1 to n, with 1 ≤ n ≤ 10 <sup>4</sup>. Reconstruction means building a shortest common supersequence of the sequences in seqs (i.e., a shortest sequence so that all sequences in seqs are subsequences of it). Determine whether there is only one sequence that can be reconstructed from seqs and it is the org sequence.

**Example1:**  
``` 
Input:
org: [1,2,3], seqs: [[1,2],[1,3]]

Output:
false

Explanation:
[1,2,3] is not the only one sequence that can be reconstructed, because [1,3,2] is also a valid sequence that can be reconstructed.
```   

**Example2:**  
``` 
Input:
org: [1,2,3], seqs: [[1,2],[1,3]]

Output:
false

Explanation:
[1,2,3] is not the only one sequence that can be reconstructed, because [1,3,2] is also a valid sequence that can be reconstructed.
```    

**Example3:**  
``` 
Input:
org: [1,2,3], seqs: [[1,2],[1,3],[2,3]]

Output:
true

Explanation:
The sequences [1,2], [1,3], and [2,3] can uniquely reconstruct the original sequence [1,2,3].
```   

**Example4:**  
``` 
org: [4,1,5,2,6,3], seqs: [[5,2,6,3],[4,1,5,2]]

Output:
true
```     

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [Google](https://leetcode.com/company/linkedin/) 
* Related Topics: * [Topological Sort](https://leetcode.com/tag/topological-sort/) * [graph](https://leetcode.com/tag/graph/)
* Similar Questions * [(M) 261. Graph Valid Tree](https://leetcode.com/problems/graph-valid-tree/)