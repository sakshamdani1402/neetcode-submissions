class Solution {
    int dp[];
    private int findCost(int[] cost,int i,int n) {
        if(i >= n) {
            return 0;
        }
        if(dp[i] > 0) {
            return dp[i];
        }
        int result = Math.min(cost[i] + findCost(cost, i+1, n), cost[i] + findCost(cost, i+2, n));
        dp[i] = result; 
        return result;
    }
    // public int minCostClimbingStairs(int[] cost) {
    //     if(cost.length == 0) {
    //         return 0;
    //     }
    //     if(cost.length == 1) {
    //         return cost[0];
    //     }
    //     int n = cost.length;
    //     dp = new int[n + 1];
    //     int idx1 = Math.min(cost[0] + findCost(cost, 1, n), cost[0] + findCost(cost, 2, n));
    //     int idx2 = Math.min(cost[1] + findCost(cost, 2, n), cost[1] + findCost(cost, 3, n));
    //     return Math.min(idx1,idx2);
    // }
    public int minCostClimbingStairs(int[] cost) {
        if(cost.length == 0) {
            return 0;
        }
        if(cost.length == 1) {
            return cost[0];
        }
        int n = cost.length;
        for(int i = n - 3; i >= 0; i--) {
            cost[i] += Math.min(cost[i+1], cost[i+2]);
        }
        return Math.min(cost[0], cost[1]);
    }
}
