# 894. 1380. Log Sorting
[Original Page](https://www.lintcode.com/problem/log-sorting/description)

Given a list of string logs, in which each element representing a log. Each log can be separated into two parts by the **first space**.  
The first part is the **ID** of the log, while the second part is the **content** of the log. (The content may contain spaces as well.)  
The content is composed of **only letters and spaces**, or **only numbers and spaces**.  

Now you need to sort logs by following rules:  
* Logs whose content is letter should be ahead of logs whose content is number.
* Logs whose content is letter should be sorted by their content in lexicographic order. And when two logs have same content, sort them by ID in lexicographic order.
* Logs whose content is number should be in their input order.
```
Example1:
Input:  
    logs = [
        "zo4 4 7",
        "a100 Act zoo",
        "a1 9 2 3 1",
        "g9 act car"
    ]
Output: 
    [
        "a100 Act zoo",
        "g9 act car",
        "zo4 4 7",
        "a1 9 2 3 1"
    ]
Explanation: "Act zoo" < "act car", so the output is as above.
```
  
```
Example2:
Input:  
    logs = [
        "zo4 4 7",
        "a100 Actzoo",
        "a100 Act zoo",
        "Tac Bctzoo",
        "Tab Bctzoo",
        "g9 act car"
    ]
Output: 
    [
        "a100 Act zoo",
        "a100 Actzoo",
        "Tab Bctzoo",
        "Tac Bctzoo",
        "g9 act car",
        "zo4 4 7"
    ]
Explanation:
    Because "Bctzoo" == "Bctzoo", the comparison "Tab" and "Tac" have "Tab" < Tac ", so" Tab Bctzoo "< Tac Bctzoo".
    Because ' '<'z', so "A100 Act zoo" < A100 Actzoo".
```  
**Note:**
* The total number of logs will not exceed 5000
* The length of each log will not exceed 100
* Each log's ID is unique.
```

---

* Difficulty: [Medium](https://leetcode.com/problemset/all/?difficulty=Medium)
* Companies: * [Amazon](https://leetcode.com/company/amazon/)
* Related Topics: * [Array](https://leetcode.com/tag/array/) 	* [Sort](https://leetcode.com/tag/sort/)
* Similar Questions: 
  * [(M) 148. Sort List](https://leetcode.com/problems/sort-list/description/)
  * [(M) 280. Wiggle Sort](https://leetcode.com/problems/wiggle-sort/description/)
  * [(M) 324. Wiggle Sort II](https://leetcode.com/problems/wiggle-sort-ii/description/)
