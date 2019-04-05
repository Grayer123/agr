class Solution {
public:
    /*
     * @param : a string to be split
     * @return: all possible split string array
     */
    vector<vector<string>> splitString(string& s) {
        // dfs; backtracking
        // tc:O(); sc:O(n)
        if(s.size() == 0) {
            return {{}};
        }
        vector<vector<string>> res;
        vector<string> path;
        findSplits(s, res, path, 0);
        return res;
    }

private:
    void findSplits(string& s, vector<vector<string>>& res, vector<string> path, int pos) {
        if(pos >= s.size()) {
           res.push_back(path); 
            return;
        }
        path.push_back(s.substr(pos, 1));
        findSplits(s, res, path, pos + 1);
        path.pop_back();
        if(pos + 1 < s.size()) {
            path.push_back(s.substr(pos, 2));
            findSplits(s, res, path, pos + 2);
            path.pop_back();
        }
        
    }
};