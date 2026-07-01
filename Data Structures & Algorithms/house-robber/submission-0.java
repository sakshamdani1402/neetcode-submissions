class Solution {
    int dp[];
    private int find(int[] nums,int i,int n) {
        if(i >= n) {
            return 0;
        }
        if(dp[i] > 0) return dp[i];
        int result = Math.max(nums[i] + find(nums, i + 2, n), find(nums, i + 1, n));
        dp[i] = result;
        return result;
    }
    public int rob(int[] nums) {
        int n = nums.length;
        dp = new int[n];
        return find(nums, 0, n);
    }
}
