class Solution {
public:
    /**
     * @param key: A string you should hash
     * @param HASH_SIZE: An integer
     * @return: An integer
     */
    int hashCode(string &key, int HASH_SIZE) {
        // hash function
        // tc:O(n); sc:O(1)
        if(key.size() == 0) {
            return 0;
        }
        long res = 0;
        int magicNum = 33;
        for(auto ch : key) {
             res = (res * magicNum + ch) % HASH_SIZE;  // version 1
             // res = (res * magicNum + (int)ch) % HASH_SIZE; // version 2
            //res = (res * magicNum + (ch - '\0')) % HASH_SIZE; // version 3
        }
        return (int)res;
    }
};