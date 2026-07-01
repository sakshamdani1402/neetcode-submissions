class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
        unordered_map<int, int> seen;
        int res = 0;
        for(auto i : nums) {
            if(!seen[i]) {
                int count = seen[i-1] + 1 + seen[i+1];
                seen[i] = count;
                seen[i - seen[i-1]] = count;
                seen[i + seen[i+1]] = count;
                res = max(res, count);
            }
        }
        return res;
    }
};
