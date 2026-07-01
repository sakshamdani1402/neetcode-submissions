class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_set<int> set;
        for(auto i: nums) {
            if(set.find(i) != set.end()) {
                return true;
            }
            set.insert(i);
        }
        return false;
    }
};
