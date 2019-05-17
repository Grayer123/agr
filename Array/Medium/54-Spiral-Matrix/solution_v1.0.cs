class Solution {
public:
    vector<int> spiralOrder(vector<vector<int>>& matrix) {
        //matrix
        //TC:O(n^2); SC:O(1)
		if (matrix.empty()){//corner case
			return {};
		}
		vector<int> res;
		int left = 0, right = matrix[0].size() - 1;
		int top = 0, down = matrix.size() - 1;
		int dir = 0; //control direction
        while(left <= right && top <= down){
            if(dir % 4 == 0){
                for(int i = left; i <= right; i++){
                    res.push_back(matrix[top][i]);
                }
                top++;
            }
            else if(dir % 4 == 1){
                for(int i = top; i <= down; i++){
                    res.push_back(matrix[i][right]);
                }
                right--;
            }
            else if(dir % 4 == 2){
                for(int i = right; i >= left; i--){
                    res.push_back(matrix[down][i]);
                }
                down--;
            }
            else if(dir % 4 == 3){
                for(int i = down; i >= top; i--){
                    res.push_back(matrix[i][left]);
                }
                left++;
            }
            dir++;
        }
        return res;
    }
};