class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    // 1,1 => 1
    // 2, 2 => 2
    // -6, - 6 => -3 , -6 => 2
    // -24, -24 => 4, 24 => 4
    maxProduct(nums) {
        let res = nums[0];
        let curMin = 1;
        let curMax = 1;

        nums.forEach( num => {
            const tmpMax = curMax * num;
            const tmpMin = curMin * num;
            curMax = Math.max(Math.max(tmpMin,tmpMax ), num);
            curMin = Math.min(Math.min(tmpMin, tmpMax), num);
            res = Math.max(res, curMax);
        })
        return res;
    }
}