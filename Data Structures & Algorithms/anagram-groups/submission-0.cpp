class Solution {
    private:
    bool isValidAnagram(string s, string t) {
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
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        vector<vector<string>> result;
        unordered_map<string, vector<string>> anagrams;

        for(auto s: strs) {
            string x = s;
            sort(x.begin(), x.end());
            anagrams[x].push_back(s);
        }
        for(auto i : anagrams) {
            result.push_back(i.second);
        }
        return result;
    }
};
