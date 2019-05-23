/**
 * Definition for a Record
 * class Record {
 * public:
 *   int id, score;
 *   Record(int id, int score) {
 *     this->id = id;
 *     this->score = score;
 *   }
 * };
 */
class Solution {
public:
    /**
     * @param results a list of <student_id, score>
     * @return find the average of 5 highest scores for each person
     * map<int, double> (student_id, average_score)
     */
    map<int, double> highFive(vector<Record>& results) {
        // map; heap
        // tc:O(nlogk); sc:O(nlogk)
        map<int, double> ans;
        if(results.size() == 0) {
            return ans;
        }
        map<int, priority_queue<int, vector<int>, greater<int>>> dict; // minHeap
        for(auto res : results) {
            dict[res.id].push(res.score);
            if(dict[res.id].size() > 5) {
                dict[res.id].pop();
            }
        }
        
        for(auto pr : dict) {
            double sum = 0;
            while(pr.second.size() > 0) {
                sum += pr.second.top();
                pr.second.pop();
            }
            ans[pr.first] = (double)(sum / 5);
        }
        return ans;
    }
};