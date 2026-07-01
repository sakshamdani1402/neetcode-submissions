class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
        if(nums.size() == 0) return 0;
        int n=nums.size(), maxLen = 1;
        unordered_map<int, int> seen;
        
        for(auto i=0; i<n ; i++) seen[nums[i]] = i;

        for(auto i : nums) {

            if(seen.find(i-1) == seen.end()) {
                continue;
            }
            int len = 1;
            
            while(seen.find(i-1) != seen.end()) {
                len++, i--;
            }

            maxLen = max(maxLen, len);
        }
        return maxLen;
    }
};
