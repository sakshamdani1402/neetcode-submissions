class Solution {
    /**
     * @param {number[][]} intervals
     * @return {number[][]}
     */
    merge(intervals) {
        intervals.sort((a, b) => {
            return a[0] - b[0]
        });
        let res = [intervals[0]];
        console.log(intervals);
        for (let i = 1; i < intervals.length; i++) {
            const [x, y] = intervals[i];
            const [_, y0] = res[res.length - 1];
            if (x <= y0) {
                res[res.length-1][1] = Math.max(y,y0);
            } else {
                res.push(intervals[i]);
            }
        }
        return res;
    }
}
