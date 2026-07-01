class Solution {
    /**
     * @param {number} n
     * @return {number}
     */
    climbStairs(n) {
        if(n === 1) {
            return 1;
        }
        let a = 0, b = 1;
        while(n--) {
            const temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
