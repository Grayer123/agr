public class CacheNode {
    public int key;
    public int val;
    public CacheNode next;
    public CacheNode(int k, int v) {
        key = k;
        val = v;
    }   
}

public class LRUCache {

    public LRUCache(int capacity) {
        this.capacity = capacity;
        head = new CacheNode(-1, -1);
        tail = head;
        dictPrev = new Dictionary<int, CacheNode>(); 
    }
    
    public int Get(int key) {
        if(!dictPrev.ContainsKey(key)) {
            return -1;
        }
        if(dictPrev[key].next != tail) {  //  if the elem is already in tail, no action needed   
            MoveToTail(dictPrev[key]); // pass prev node
            // DeleteNode(dictPrev[key]); // pass prev node
        }      
        return dictPrev[key].next.val;
    }
    
    public void Put(int key, int value) {
        if(dictPrev.ContainsKey(key)) {
            dictPrev[key].next.val = value;
            Get(key);
            return;
        }
        if(dictPrev.Count == capacity) {     
            dictPrev.Remove(head.next.key);
            head.next = head.next.next;
            if(head.next != null) {
                dictPrev[head.next.key] = head;
            }
        }
        CacheNode node = new CacheNode(key, value);                 
        dictPrev[key] = tail;
        tail.next = node;
        tail = node;
    }
    
    private void MoveToTail(CacheNode prev) {
        CacheNode cur = prev.next;
        if(cur == tail) {
            return;
        }
        prev.next = cur.next; // delete the node 
        cur.next = null; // disconnect 
        if(prev.next != null) {
            dictPrev[prev.next.key] = prev;
        }
        dictPrev[cur.key] = tail;
        tail.next = cur;
        tail = cur;
    }
    
    private int capacity;
    private CacheNode head;
    private CacheNode tail;
    private Dictionary<int, CacheNode> dictPrev;
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */