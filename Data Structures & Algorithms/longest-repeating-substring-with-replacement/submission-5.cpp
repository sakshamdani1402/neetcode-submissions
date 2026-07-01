class Solution {
public:
    int characterReplacement(string s, int k) {
        vector<int> freq(26, 0);
        int i = 0, j = 0, n = s.size();
        int maxLen = 0;
        int maxFreq = 0;
        char A = 'A';
        while(j < n) {
            freq[s[j] - A]++;
            int len = j - i + 1;
            maxFreq = max(maxFreq, freq[s[j] - A]);
            if(len - maxFreq > k) {
                freq[s[i] - A]--;
                i++;
            } else {
                maxLen = max(maxLen, len);
            }
                j++;
        }
        return maxLen;
    }
};
