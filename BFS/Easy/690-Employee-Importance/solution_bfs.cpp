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
        // bfs
        // tc:O(n); sc:O(n)
        if(employees.size() == 0) {
            return 0;
        }
        int res = 0;
        unordered_map<int, Employee*> dict;
        for(auto em : employees) {
            dict[em->id] = em;
        }
        queue<Employee*> q;
        q.push(dict[id]);
        while(!q.empty()) {
            auto employee = q.front();
            q.pop();
            dict.erase(employee->id);
            res += employee->importance;
            for(auto subId : employee->subordinates) {
                if(dict.find(subId) != dict.end()) {
                    q.push(dict[subId]);
                }
            }
        }
        return res;
    }
};