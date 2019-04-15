public class CacheNode {
    public int key;
    public int val;
    public CacheNode prev;
    public CacheNode next;
    public CacheNode(int k, int v) {
        key = k;
        val = v;
    }   
}

public class LRUCache {

    public LRUCache(int capacity) {
        this.capacity = capacity;
        dummy = new CacheNode(-1, -1);
        tail = dummy;
        dict = new Dictionary<int, CacheNode>(); 
    }
    
    public int Get(int key) {
        if(!dict.ContainsKey(key)) {
            return -1;
        }
        if(dict[key] != tail) {  //  if the elem is already in tail, no action needed
            DeleteNode(dict[key]);
            MoveToTail(dict[key]);
        }      
        return dict[key].val;
    }
    
    public void Put(int key, int value) {
        if(!dict.ContainsKey(key)) {
            CacheNode node = new CacheNode(key, value);                 
            dict[key] = node;
             MoveToTail(node);
        }
        else {
            dict[key].val = value; // update the value 
            Get(key); // delete in current sequence and move to tail
        }
    }
    
    private void DeleteNode(CacheNode node) {
        CacheNode pre = node.prev; 
        pre.next = node.next; // delete the node
        if(node.next != null) {
            node.next.prev = pre;
        }      
        node.next = null; // disconnect
        node.prev = null;
    }
    
    private void MoveToTail(CacheNode node) {
        if(dict.Count > capacity) {
            dict.Remove(dummy.next.key);
            DeleteNode(dummy.next);
        }
        tail.next = node;
        node.prev = tail;
        tail = tail.next;
    }
    
    private int capacity;
    private CacheNode dummy;
    private CacheNode tail;
    private Dictionary<int, CacheNode> dict;
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */