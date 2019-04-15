/*
 * @lc app=leetcode id=705 lang=csharp
 *
 * [705] Design HashSet
 *
 * https://leetcode.com/problems/design-hashset/description/
 *
 * algorithms
 * Easy (51.97%)
 * Total Accepted:    17.7K
 * Total Submissions: 33.9K
 * Testcase Example:  '["MyHashSet","add","add","contains","contains","add","contains","remove","contains"]\n[[],[1],[2],[1],[3],[2],[2],[2],[2]]'
 *
 * Design a HashSet without using any built-in hash table libraries.
 * 
 * To be specific, your design should include these functions:
 * 
 * 
 * add(value): Insert a value into the HashSet. 
 * contains(value) : Return whether the value exists in the HashSet or not.
 * remove(value): Remove a value in the HashSet. If the value does not exist in
 * the HashSet, do nothing.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * MyHashSet hashSet = new MyHashSet();
 * hashSet.add(1);         
 * hashSet.add(2);         
 * hashSet.contains(1);    // returns true
 * hashSet.contains(3);    // returns false (not found)
 * hashSet.add(2);          
 * hashSet.contains(2);    // returns true
 * hashSet.remove(2);          
 * hashSet.contains(2);    // returns false (already removed)
 * 
 * 
 * 
 * Note:
 * 
 * 
 * All values will be in the range of [0, 1000000].
 * The number of operations will be in the range of [1, 10000].
 * Please do not use the built-in HashSet library.
 * 
 * 
 */


public class ListNode {
    int val;
    ListNode next;
    public ListNode(int v) {
        this.val = v;
        this.next = null;
    }
}

public class MyHashSet {

    /** Initialize your data structure here. */
    public MyHashSet() {
        hashSet = new ListNode[INIT_SIZE];
        curSize = INIT_SIZE;
        count = 0;
    }
    
    public void Add(int key) {
        int index = GetHashCode(key);
        ListNode newNode = new ListNode(key);
        if(hashSet[index] == null) {
            //Console.Write("key empty: {0}", key);
            hashSet[index] = newNode;
        }
        else {
            ListNode cur = hashSet[index];
            ListNode prev = cur;
            while(cur != null) {
                if(cur.val == key) { // already exist
                    return; 
                }
                prev = cur;
                cur = cur.next;
            }
            prev.next = newNode;
        }
        count++;
        if((double)count >= (double)curSize * resizeFactor) {
            Console.WriteLine("rehashing");
            Rehash();
        }
    }
    
    public void Remove(int key) {
        int index = GetHashCode(key);
        if(hashSet[index] == null) {  // nothing to remove
            return;
        }
        ListNode prev = null;
        ListNode curNode = hashSet[index];
        while(curNode != null) {
            if(curNode.val == key) { // find the node
                break; 
            }
            prev = curNode;
            curNode = curNode.next;
        }
        if(curNode == null) { // does not find 
            return; 
        }
        if(prev == null) { // need to remove head node 
            hashSet[index] = curNode.next;
            curNode.next = null;
        }
        else {
            prev.next = prev.next.next;
            curNode.next = null;
        }
        count--;

    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        int index = GetHashCode(key);
        if(hashSet[index] == null) {
            return false;
        }
        ListNode curNode = hashSet[index];
        while(curNode != null) {
            if(curNode.val == key) {
                return true;
            }
            curNode = curNode.next;
        }
        return false;
    }
    
    private int GetHashCode(int key) {
        return (key % curSize + curSize) % curSize; // in case key is a negative number
    }

    private void Rehash() {
        curSize *= 2;
        ListNode[] newHashSet = new ListNode[curSize];
        foreach(var node in hashSet) {
            ListNode oldNode = node;
            while(oldNode != null) {
                int newIdx = GetHashCode(oldNode.val);
                ListNode newNode = new ListNode(oldNode.val);
                if(newHashSet[newIdx] == null) {
                    newHashSet[newIdx] = newNode;
                }
                else {
                    ListNode curNode = newHashSet[newIdx];
                    while(curNode.next != null) {
                        curNode = curNode.next;
                    }
                    curNode.next = newNode;
                }
                oldNode = oldNode.next;
            }
        }
        hashSet = newHashSet;
    }
    
    private ListNode[] hashSet;
    private const int INIT_SIZE = 100;
    private const double resizeFactor = 0.75;
    private int curSize;
    private int count;
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */

