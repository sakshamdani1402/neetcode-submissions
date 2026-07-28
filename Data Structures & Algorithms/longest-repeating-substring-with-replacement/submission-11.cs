public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxCharCount = 0;
        int res = 0;
        int l = 0, r = 0, n = s.Length;
        Dictionary<char, int> freq = new ();
        while(r < n) {
            int count = freq.GetValueOrDefault(s[r]);
            freq[s[r]] = count + 1;

            maxCharCount = Math.Max(maxCharCount, freq[s[r]]);
            int len = r - l + 1;
            if(len - maxCharCount <= k) {
                res = Math.Max(res, len);
            }
            else {
                freq[s[l++]]--;
            }
            r++;
        }

        return res;
    }
}
