class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int,int> freq;
        priority_queue<pair<int,int>, vector<pair<int,int>>> pq;
        for(auto &i: nums) {
            freq[i] ++;
        }
        for(auto item : freq) {
            pq.push({item.second, item.first});
        }
        int i = 0;
        vector<int> result;
        while(i < k) {
            result.push_back(pq.top().second);
            pq.pop();
            i++;
        }
        return result;
    }
};
