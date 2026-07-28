public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int currMin = int.MaxValue;
        foreach(int price in prices) {
            currMin = Math.Min(currMin, price);
            profit = Math.Max(profit, price - currMin);
        }
        return profit;
    }
}
