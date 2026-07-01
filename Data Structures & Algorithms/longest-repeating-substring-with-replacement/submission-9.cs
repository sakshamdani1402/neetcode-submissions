public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0, r = 0;
        int n = s.Length;
        int maxCharCount = 0;
        int maxLen = 0;
        Dictionary<char, int> freq = new();
        while(r < n) {
            if(freq.ContainsKey(s[r])) {
                freq[s[r]]++;
            } else {
                freq[s[r]] = 1;
            }
            int len = r - l + 1;
            maxCharCount = Math.Max(maxCharCount, freq[s[r]]);
            if(len - maxCharCount <= k) {
                maxLen = Math.Max(len, maxLen);
            } else {
                freq[s[l]]--;
                l++;
            }
            r++;
        }
        return maxLen;
    }
}
