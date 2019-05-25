class Solution {
public:
    string intToRoman(int num) {
        //string; math
		//SR; TC:O(n); SC:O(n)
		const int M = 13;
		const string rome[M] = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
		const int digit[M] = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
		string res;
		int idx = 0;
		while(num > 0 && idx < M){
		    int cnt = 0;
		    if(num >= digit[idx]){
		        cnt = num / digit[idx];
		        num -= cnt * digit[idx];
		    }
		    while(cnt){
		        res += rome[idx];
		        cnt--;
		    }
		    idx++;
		}
        return res;
    }
};