class Solution {
    /**
     * @param {number} m
     * @param {number} n
     * @return {number}
     */
    constructor() {
        this.memo = [];
        this.m = 0;
        this.n = 0;
    }
    find(i, j) {
        if(i === this.m - 1 && j === this.n - 1) {
            return 1;
        }

        if(i >= this.m || j >= this.n) {
            return 0;
        }

        if(this.memo[i][j] !== 0) {
            console.log(this.memo[i][j] + "for " + i + ' ' + j );
            return this.memo[i][j];
        }

        let res = this.find(i+1, j) + this.find(i, j+1);
        this.memo[i][j] = res;
        return res;
        // return this.memo[i][j];
    }
    uniquePaths(m, n) {
        this.m = m;
        this.n = n;
        this.memo = Array.from({ length: m }, () => new Array(n).fill(0));;
        // console.log(this.memo);
        return this.find(0,0);
    }
}
