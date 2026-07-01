class Solution {
    /**
     * @param {string} s
     * @param {number} k
     * @return {number}
     */

    // when len - maxFreq > k then update maxLen
    //
    freq = new Map();
    updateMap = (key, decrement) => {
        let value = this.freq.get(key) || 0;
        if(!decrement) {
            this.freq.set(key, ++value);
        } else {
            this.freq.set(key, --value);
        }
    }
    characterReplacement(s, k) {
        let low = 0, high = 0;
        let n = s.length;
        let maxfreq = 0, maxLen = 0;
        while(high < n) {
            this.updateMap(s[high], false);
            maxfreq = Math.max(maxfreq, this.freq.get(s[high]));
            const len = high - low + 1;
           if(len - maxfreq <= k) {
            maxLen = Math.max(maxLen, len);
           } else {
            this.updateMap(s[low], true);
            low++;
           }
           high++;
        }
        return maxLen;
    }
}
