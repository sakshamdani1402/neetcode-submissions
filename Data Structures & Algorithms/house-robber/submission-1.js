class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    rob(nums) {
        const n = nums.length;
        const dp = new Array(n+2).fill(0);
        // 16 15 14 6 6 0 0 
        for(let i = n - 1; i >= 0 ; i--){
            dp[i] = Math.max(dp[i+1], nums[i] + dp[i+2]);
        }

        return dp[0];
    }
}
