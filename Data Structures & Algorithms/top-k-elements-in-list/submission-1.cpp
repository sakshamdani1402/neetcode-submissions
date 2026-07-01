class Solution {
    struct compare {
        bool operator()(pair<int,int> a, pair<int,int> b) {
            return a.first > b.first;
        }
    };

public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        priority_queue<pair<int, int>, vector<pair<int,int>>, compare> minheap;
        unordered_map<int,int> freq;
        for(int i =0 ; i<nums.size(); i++) {
            freq[nums[i]] ++;
        }
        for(auto p: freq) {
            minheap.push({p.second, p.first});
            if(minheap.size() > k) {
                minheap.pop();
            }
        }
        vector<int> result;
        while(k-- && !minheap.empty()) {
            auto p = minheap.top();
            minheap.pop();
            result.push_back(p.second);
        }
        return result;
    }
};
