class TwoSum {
public:
    void add(int number) {
        if(hashMap.find(number) == hashMap.end()){
            hashMap[number] = 1;
        }
        else{
            hashMap[number]++;
        }
    }

    bool find(int value) {
        for(auto iter = hashMap.begin(); iter != hashMap.end(); iter++){
            int num1 = iter->first;
            int num2 = value - num1;
            if(hashMap.find(num2) != hashMap.end()){
                if(num1 != num2 || hashMap[num2] >= 2){
                    return true;
                }
            }
        }
        return false;
    }
private:
    unordered_map<int, int> hashMap;
};