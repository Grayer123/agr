/*
 * @lc app=leetcode id=706 lang=csharp
 *
 * [706] Design HashMap
 *
 * https://leetcode.com/problems/design-hashmap/description/
 *
 * algorithms
 * Easy (55.40%)
 * Total Accepted:    27.4K
 * Total Submissions: 49.4K
 * Testcase Example:  '["MyHashMap","put","put","get","get","put","get", "remove", "get"]\n[[],[1,1],[2,2],[1],[3],[2,1],[2],[2],[2]]'
 *
 * Design a HashMap without using any built-in hash table libraries.
 * 
 * To be specific, your design should include these functions:
 * 
 * 
 * put(key, value) : Insert a (key, value) pair into the HashMap. If the value
 * already exists in the HashMap, update the value.
 * get(key): Returns the value to which the specified key is mapped, or -1 if
 * this map contains no mapping for the key.
 * remove(key) : Remove the mapping for the value key if this map contains the
 * mapping for the key.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * MyHashMap hashMap = new MyHashMap();
 * hashMap.put(1, 1);          
 * hashMap.put(2, 2);         
 * hashMap.get(1);            // returns 1
 * hashMap.get(3);            // returns -1 (not found)
 * hashMap.put(2, 1);          // update the existing value
 * hashMap.get(2);            // returns 1 
 * hashMap.remove(2);          // remove the mapping for 2
 * hashMap.get(2);            // returns -1 (not found) 
 * 
 * 
 * 
 * Note:
 * 
 * 
 * All keys and values will be in the range of [0, 1000000].
 * The number of operations will be in the range of [1, 10000].
 * Please do not use the built-in HashMap library.
 * 
 * 
 */
public class HashNode {
    public int key;
    public int val;
    public HashNode next;
    public HashNode(int k, int v) {
        this.key = k;
        this.val = v;
        this.next = null;
    }
}

public class MyHashMap {
    /** Initialize your data structure here. */
    public MyHashMap() {
        hashMap = new HashNode[INIT_SIZE];
        curSize = INIT_SIZE;
        count = 0;
    }
    
    /** value will always be non-negative. */
    public void Put(int key, int value) {
        int index = GetHashCode(key);
        HashNode newNode = new HashNode(key, value);
        if(hashMap[index] == null) { // does not exist
            hashMap[index] = newNode;
        }
        else {
            HashNode cur = hashMap[index];
            HashNode prev = cur;
            while(cur != null) {
                if(cur.key == key) { // already exist
                    cur.val = value; // update the value
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
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key) {
        int index = GetHashCode(key);
        if(hashMap[index] == null) { // does not exist
            return -1;
        }
        HashNode curNode = hashMap[index];
        while(curNode != null) {
            if(curNode.key == key) { // find the match
                return curNode.val;
            }
            curNode = curNode.next;
        }
        return -1;
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key) {
        int index = GetHashCode(key);
        if(hashMap[index] == null) {  // nothing to remove
            return;
        }
        HashNode prev = null;
        HashNode curNode = hashMap[index];
        while(curNode != null) {
            if(curNode.key == key) { // find the node
                break; 
            }
            prev = curNode;
            curNode = curNode.next;
        }
        if(curNode == null) { // does not find 
            return; 
        }
        if(prev == null) { // need to remove head node 
            hashMap[index] = curNode.next;
            curNode.next = null;
        }
        else {
            prev.next = prev.next.next;
            curNode.next = null;
        }
        count--;
    }
    
    private int GetHashCode(int key) {
        return (key % curSize + curSize) % curSize; // in case key is a negative number
    }

    private void Rehash() {
        curSize *= 2; // enlarge the current size to 2 times
        HashNode[] newHashMap = new HashNode[curSize];
        foreach(var node in hashMap) {
            HashNode oldNode = node;
            while(oldNode != null) {
                int newIdx = GetHashCode(oldNode.key);
                HashNode newNode = new HashNode(oldNode.key, oldNode.val);
                if(newHashMap[newIdx] == null) {
                    newHashMap[newIdx] = newNode;
                }
                else {
                    HashNode curNode = newHashMap[newIdx];
                    while(curNode.next != null) {
                        curNode = curNode.next;
                    }
                    curNode.next = newNode;
                }
                oldNode = oldNode.next;
            }
        }
        hashMap = newHashMap;
    }
    
    private HashNode[] hashMap;
    private const int INIT_SIZE = 100;
    private const double resizeFactor = 0.75;
    private int curSize;
    private int count;
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */

