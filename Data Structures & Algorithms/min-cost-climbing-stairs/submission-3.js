class Solution {
    /**
     * @param {number[]} cost
     * @return {number}
     */
    minCostClimbingStairs(cost) {
        const n = cost.length;
        
        // 1 2 3
        // 0 2 3 0 0
        const dp = new Array(n + 2).fill(0);
        for(let i = n - 1; i >= 0; i--) {
            dp[i] = Math.min(cost[i] + dp[i + 1], cost[i] + dp[i + 2]);
        }
        return Math.min(dp[0], dp[1]);
    }
}
