class Solution {
    bool isOpenBracket(char& c) {
        return c == '(' || c == '[' || c=='{';
    }
    char getCounterBracket(char& c) {
        if(c == ')') return '(';
        else if(c == '}') return '{';
        else return '[';
    }
public:
    bool isValid(string s) {
        stack<char> st;
        for(char c: s) {
            if(isOpenBracket(c)) {
                st.push(c);
            }
            else { 
                if(!st.empty() && (st.top() == getCounterBracket(c))){
                    st.pop();}
                else return false;
            }
        }
        return st.empty();
    }
};
