class Solution {
    string join(vector<int>& arr) {
        string res = "";
        for(int i: arr) {
            res += (to_string(i) + ",");
        }
        return res;
    }
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> map;

        for(string s: strs) {
            vector<int> freq(26,0);
            for(char c: s) freq[c - 'a']++;

            string k = join(freq);
            map[k].push_back(s);
        }

        vector<vector<string>> res;
        for(auto p: map) {
            res.push_back(p.second);
        }

        return res;
    }
};
