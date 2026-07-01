class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    dict = {};
    getValue = (n) => {
        if(this.dict.hasOwnProperty(n)) {
            return this.dict[n];
        }
        return 0;
    }
    longestConsecutive(nums) {
        const n = nums.length;
        if(n === 0) {
            return 0;
        }
        let maxLen = 1;
        // LCS at i = LCS ending at i - 1 + 1 + LCS starting at i + 1
        for(const i of nums) {
            if(this.getValue(i) !== 0) {
                continue;
            }
                const lcs = this.getValue(i-1) + 1 + this.getValue(i+1);
                this.dict[i] = lcs;
                this.dict[i - this.getValue(i - 1)] = lcs;
                this.dict[i + this.getValue(i + 1)] = lcs;
                maxLen = Math.max(lcs, maxLen);
        }
        return maxLen;
    }
}
