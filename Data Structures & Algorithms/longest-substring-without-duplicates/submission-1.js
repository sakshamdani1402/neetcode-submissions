class Solution {
    /**
     * @param {string} s
     * @return {number}
     */

    //p w w k e w
    lengthOfLongestSubstring(s) {
        const n = s.length;
        if(n === 0) {
            return 0;
        }
        let l = 0, r = 0, maxLen = 1;
        const seen = {};
        while(r < n) {
           if(seen.hasOwnProperty(s[r])) {
            l = Math.max(seen[s[r]] + 1, l);
           }
           seen[s[r]] = r;
           maxLen = Math.max(maxLen, r - l + 1);
           r++;
        }
        return maxLen;
    }
}
