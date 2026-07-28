public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0) {
            return 0;
        }
        HashSet<char> seen = new ();
        int l = 0, r = 0;
        int lcs = 1;
        while(r <= s.Length - 1) {
           while(seen.Contains(s[r])) {
                seen.Remove(s[l++]);
           }
           seen.Add(s[r]);
           lcs = Math.Max(lcs, r - l + 1);
           r++;
        }

        return lcs;
    }
}
