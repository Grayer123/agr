public class HashFunction {
    public int GetHashCode(string key, int HASH_SIZE) {
        if(string.IsNullOrEmpty(key)) {
            return 0;
        }
        long res = 0;
        int magicNum = 33;
        foreach(char ch in key) {
            res = (res * magicNum + ch) % HASH_SIZE; // version 1
            // res = (res * magicNum + (ch - '\0')) % HASH_SIZE; // version 2
            // res = (res * magicNum + (int)ch) % HASH_SIZE; // version 2
        }
        return (int)res;
    }
}