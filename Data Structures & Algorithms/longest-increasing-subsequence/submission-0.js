class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    constructor() {
    }
    find(nums, curr, prev) {
        if(curr < 0) {
            return 0;
        }
        const nottake = this.find(nums, curr-1, prev);
        let take = 0;
        if(prev === -1 || nums[curr] < nums[prev]) {
            take = 1 + this.find(nums, curr-1, curr);
        }
        return Math.max(nottake, take);
    }
    lengthOfLIS(nums) {
        const n = nums.length;
        return this.find(nums, n-1, -1);
    }
}
