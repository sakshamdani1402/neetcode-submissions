class Solution {
    pair<int,int> getNums(stack<int>& st) {
        if(st.size()  < 2) return {0,0};
        int x = st.top(); st.pop();
        int y = st.top(); st.pop();
        return {x , y};
    }
public:
    int evalRPN(vector<string>& tokens) {
        stack<int> st;
        for(string c: tokens) {
            if(c == "+") {
                auto p = getNums(st);
                st.push(p.first + p.second);
            }
            else if(c == "-") {
                auto p = getNums(st);
                st.push(p.second - p.first);
            }
            else if(c == "*") {
                auto p = getNums(st);
                st.push(p.first * p.second);
            }
            else if(c == "/"){
                auto p = getNums(st);
                st.push(static_cast<int>(static_cast<double>(p.second) / p.first));
            }
            else    st.push(stoi(c));
        }
        return st.top();
    }
};
// [22]
