/*
// Employee info
class Employee {
public:
    // It's the unique ID of each node.
    // unique id of this employee
    int id;
    // the importance value of this employee
    int importance;
    // the id of direct subordinates
    vector<int> subordinates;
};
*/
class Solution {
public:
    int getImportance(vector<Employee*> employees, int id) {
        // dfs
        // tc:O(n); sc:O(n)
        if(employees.size() == 0) {
            return 0;
        }
        int res = 0;
        unordered_map<int, Employee*> dict;
        for(auto em : employees) {
            dict[em->id] = em;
        }
        dfs(dict, id, res);
        return res;
    }
private:
    void dfs(unordered_map<int, Employee*>& dict, int id, int& res) {
        if(dict.find(id) == dict.end()) {
            return;
        }
        auto em = dict[id];
        dict.erase(em->id);
        res += em->importance;
        for(int subId : em->subordinates) {
            dfs(dict, subId, res);
        }
    }
};