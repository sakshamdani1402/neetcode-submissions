class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        unordered_set<char> seen;
        int n = s.size();
        int i = 0, j = 0;
        int res = 0;
        while(j < n) {
            while(j<n && seen.find(s[j]) == seen.end()) {
                seen.insert(s[j++]);
            }
            res = max(res, j - i);
            i++;j=i;
            seen.clear();
        }
        return res;
    }
};
