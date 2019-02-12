class Solution {
public:
    string minWindow(string s, string t) {
        //hash table; two pointers;
        //TC:O(n); SC:O(n)
        if(s.size() < t.size()){//corner case
            return "";
        }
        int hash[128];
        fill_n(hash, 128, 0);
        fill_t(t, hash);
        int slow = 0, fast = 0;
        string minString = "";
        int minLen = INT_MAX;
        for(slow = 0; slow < s.size(); slow++){
            while(fast < s.size() && (fast - slow < t.size() || !checkHash(hash))){
                hash[s[fast]]++;
                fast++;
            }
            if(!checkHash(hash)){
                break;
            }
            if(fast - slow < minLen){
                minLen = fast - slow;
                minString = s.substr(slow, fast - slow);
            }
            hash[s[slow]]--;
        }
        return minString;
    }
    
private:
    void fill_t(const string& t, int* hash){
        for(char c : t){
            hash[c]--;
        }
    }
    
    bool checkHash(int* hash){
        for(int i = 0; i < 128; i++){
            if(hash[i] < 0){
                return false;
            }
        }
        return true;
    }
};