class Solution {
    private int findCost(int[] cost,int i,int n) {
        if(i >= n) {
            return 0;
        }
        return Math.min(cost[i] + findCost(cost, i+1, n), cost[i] + findCost(cost, i+2, n));
    }
    public int minCostClimbingStairs(int[] cost) {
        if(cost.length == 0) {
            return 0;
        }
        if(cost.length == 1) {
            return cost[0];
        }
        int n = cost.length;
        int idx1 = Math.min(cost[0] + findCost(cost, 1, n), cost[0] + findCost(cost, 2, n));
        int idx2 = Math.min(cost[1] + findCost(cost, 2, n), cost[1] + findCost(cost, 3, n));
        return Math.min(idx1,idx2);
    }
}
