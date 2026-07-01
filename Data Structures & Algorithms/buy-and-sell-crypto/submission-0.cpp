class Solution {
public:
    int maxProfit(vector<int>& prices) {
        if(prices.size() < 2) return 0;
        int maxProfit = 0;
        int minimum = prices[0];
        for(int i = 1; i< prices.size(); i++){
            if(prices[i] > minimum) {
                maxProfit = max(maxProfit, prices[i] - minimum);
            }
            minimum = min(minimum, prices[i]);
        }
        return maxProfit;
    }
};
