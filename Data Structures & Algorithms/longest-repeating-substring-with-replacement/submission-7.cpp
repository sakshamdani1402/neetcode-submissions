class Solution {
public:
    int characterReplacement(string s, int k) {
        vector<int> freq(26, 0);
        int i = 0, j = 0, n = s.size();
        int maxLen = 0;
        int maxFreq = 0;
        char A = 'A';
        while(j < n) {
            int charIdx = s[j] - A;
            freq[charIdx] ++;
            int len = j - i + 1;
            maxFreq = max(maxFreq, freq[charIdx]);
            if(len - maxFreq <= k) {
                maxLen = max(maxLen, len);
            }
            else {
                freq[s[i]-A]--;
                i++;
            }
            j++;
        }
        return maxLen;
    }
};
