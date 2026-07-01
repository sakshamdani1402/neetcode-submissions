class Solution {
public:
    bool isAnagram(string s, string t) {
        if(s.size() !=  t.size()) return false;
        unordered_map<char, int> seen;
        for(auto c:s) seen[c] ++;
        for(auto c: t) {
            if(!seen[c]) {
                return false;
            }
            seen[c]--;
        }
        return true;
    }
};
