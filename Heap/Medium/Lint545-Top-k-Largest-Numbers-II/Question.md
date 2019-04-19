# 373. Find K Pairs with Smallest Sums  
[Original Page](https://www.lintcode.com/problem/top-k-largest-numbers-ii/description)  

Implement a data structure, provide two interfaces:  

`add(number)`: Add a new number in the data structure.  
`topk()`: Return the top k largest numbers in this data structure. k is given when we create the data structure.  

**Example 1:**
```
Input: 
s = new Solution(3);
s.add(3)
s.add(10)
s.topk()
s.add(1000)
s.add(-99)
s.topk()
s.add(4)
s.topk()
s.add(100)
s.topk()
		
Output: 
[10, 3]
[1000, 10, 3]
[1000, 10, 4]
[1000, 100, 10]

Explanation:
s = new Solution(3);
>> create a new data structure, and k = 3.
s.add(3)
s.add(10)
s.topk()
>> return [10, 3]
s.add(1000)
s.add(-99)
s.topk()
>> return [1000, 10, 3]
s.add(4)
s.topk()
>> return [1000, 10, 4]
s.add(100)
s.topk()
>> return [1000, 100, 10]
```

**Example 2:**
```
Input: 
s = new Solution(1);
s.add(3)
s.add(10)
s.topk()
s.topk()

Output: 
[10]
[10]

Explanation:
s = new Solution(1);
>> create a new data structure, and k = 1.
s.add(3)
s.add(10)
s.topk()
>> return [10]
s.topk()
>> return [10]
```

---


* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Midium)
* Companies: * [Google](https://leetcode.com/company/google/) * [Uber](https://leetcode.com/company/uber/)
* Related Topics: * [Heap](https://leetcode.com/tag/heap/)
   
* Similar Questions 
  * [(M) 378. Kth Smallest Element in a Sorted Matrix](https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/description/)
  * [(H) 719. Find K-th Smallest Pair Distance](https://leetcode.com/problems/find-k-th-smallest-pair-distance/description/)
