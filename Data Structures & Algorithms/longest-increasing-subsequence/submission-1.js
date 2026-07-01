class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    constructor() {
        this.memo = [];
    }
    find(nums, curr, prev) {
        if(curr < 0) {
            return 0;
        }
        if(this.memo[curr][prev+1] !== 0) {
            return this.memo[curr][prev+1];
        }
        const nottake = this.find(nums, curr-1, prev);
        let take = 0;
        if(prev === -1 || nums[curr] < nums[prev]) {
            take = 1 + this.find(nums, curr-1, curr);
        }
        this.memo[curr][prev+1] = Math.max(nottake, take);
        return this.memo[curr][prev+1];
    }
    lengthOfLIS(nums) {
        const n = nums.length;
        this.memo = new Array(n+1)
                        .fill(new Array(n+1)
                                .fill(0));
        console.log(this.memo);
        return this.find(nums, n-1, -1);
    }
}
