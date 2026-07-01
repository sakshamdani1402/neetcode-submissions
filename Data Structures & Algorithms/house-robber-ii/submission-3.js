class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    find(nums, x) {
        const n = nums.length;
        let next = 0, nextnext = 0;
        let res = 0;
        const d = x === 0 ? 1 : 0
        for(let i = n - 1 - x; i >= d; i--) {
            res = Math.max(nums[i] + nextnext, next);
            nextnext = next;
            next = res;
        }
        return res;
    }
    rob(nums) {
        if(nums.length == 1) return nums[0];
        // if(nums.length === 3) {
        //     return nums[1];
        // }
        return Math.max(this.find(nums, 0), this.find(nums, 1));
    }
}
// 3 4 3
// 0 4 3 0 0
//   4 3 0 0