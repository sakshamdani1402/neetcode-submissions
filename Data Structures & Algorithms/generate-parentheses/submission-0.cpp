class Solution {
    int limit;
    void backtrack(
        int open,
        int close,
        string currentCombi,
        vector<string>& result
    ) {
        if(open == close && close == limit) {
            result.push_back(currentCombi);
            return;
        }

        if(open < limit ) {
            backtrack(open + 1, close, currentCombi + '(', result);
        }
        if(close < open) {
            backtrack(open, close + 1, currentCombi + ')', result);
        }
    }
public:
    vector<string> generateParenthesis(int n) {
        if(n < 1) return {};
        int open = 0, close = 0;
        limit = n;
        vector<string> result;
        backtrack(open, close, "", result);
        return result;
    }
};
