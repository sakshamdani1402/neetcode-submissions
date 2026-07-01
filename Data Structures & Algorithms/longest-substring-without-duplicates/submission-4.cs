public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seen = new();
        int l = 0, r = 0, n = s.Length;
        if(n <= 0) {
            return 0;
        }
        int res = 0;
        while (r < n) { 
            if (seen.Contains(s[r])) 
            { seen.Remove(s[l]); l++; } 
            else { seen.Add(s[r]); r++; res = Math.Max(res, r - l); }}
        return res;
    }
}
