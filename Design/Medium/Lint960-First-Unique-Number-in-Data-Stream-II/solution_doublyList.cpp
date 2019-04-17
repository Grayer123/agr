class DataNode {
public: 
    int key;
    DataNode* prev;
    DataNode* next;
    DataNode(int k): key(k){}
};

class DataStream {
public:
    
    DataStream(){
        // do intialization if necessary
        head = new DataNode(-1);
        tail = head;
    }
    
    /**
     * @param num: next number in stream
     * @return: nothing
     */
    void add(int num) {
        if(dict.find(num) == dict.end()) { // cannot find 
            DataNode* node = new DataNode(num);
            dict[num] = node;
            tail->next = node;
            node->prev = tail;
            tail = node;
            return;
        }
        DataNode* curNode = dict[num];
        DataNode* preNode = curNode->prev;
        if(curNode == tail) {
            tail = preNode;
        }
        preNode->next = curNode->next;  // delete current node
        if(curNode->next) {
            curNode->next->prev = preNode;
        }
        curNode->prev = nullptr; // disconnect
        curNode->next = nullptr; 
        // dict.erase(dict.find(num)); 
        dict.erase(num); // remove current node from dictionary
    }

    /**
     * @return: the first unique number in stream
     */
    int firstUnique() {
        if(!head->next) {
            throw "Invalid input";
        }
        return head->next->key;
    }
private:
    unordered_map<int, DataNode*> dict;
    DataNode* head;
    DataNode* tail;
};