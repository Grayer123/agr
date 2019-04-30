// define contentType enum
enum ContentType {
    letter,
    number
};


class Node {
public:
string id;
    string content;
    int index;
    enum ContentType type;
    
    // override < operator
    friend bool operator < (Node a, Node b) {
        if(a.type == number && b.type == number) {
            return a.index < b.index;
        }
        if(a.type == letter && b.type == letter) {
            if(a.content == b.content) {
                return a.id < b.id;
            }
            return a.content < b.content;
        }
        return a.type < b.type;
    }
};


class Solution {
public:
    /**
     * @param logs: the logs
     * @return: the log after sorting
     */
    vector<string> logSort(vector<string> &logs) {
        // sorting + comparator
        // tc:O(nlogn); sc:O(n)
        if(logs.size() == 0) {
            return {};
        }
        vector<Node> nodeArr;
        vector<string> res;
        for(int i = 0; i < logs.size(); i++) {
            int idx = logs[i].find(' ');
            Node node;
            node.index = i;
            node.id = logs[i].substr(0, idx);
            node.content = logs[i].substr(idx + 1);
            if(node.content[0] >= '0' && node.content[0] <= '9') {
                node.type = number;
            }
            else {
                node.type = letter;
            }
            nodeArr.push_back(node);
        }
        sort(nodeArr.begin(), nodeArr.end());
        for(auto node : nodeArr) {
            res.push_back(logs[node.index]);
        }
        return res;
    }
};