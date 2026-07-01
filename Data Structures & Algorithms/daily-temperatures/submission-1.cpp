class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        int n = temperatures.size();
        vector<int> result(n,0);
        stack<pair<int ,int>> st;

        for(int i=0; i<n; i++) {
            while(!st.empty() && st.top().first < temperatures[i]) {
                auto smallerTemp = st.top(); st.pop();
                result[smallerTemp.second] = i - smallerTemp.second;
            }
            st.push({temperatures[i], i});
        }
        return result;
    }
};
// [(40, 5)]
// [1,4,1,2,1,0,0]