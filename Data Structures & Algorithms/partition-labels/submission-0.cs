public class Solution {
    public List<int> PartitionLabels(string s) {
        List<int> res = new List<int>();
        Dictionary<char, int> lastSeen = new();
        for(int i = 0; i < s.Length; i++) {
            lastSeen[s[i]] = i;
        }
        int end = 0, size = 0;
        for(int i = 0; i < s.Length; i++) {
            end = Math.Max(end, lastSeen[s[i]]);
            size += 1;
            if(i == end) {
                res.Add(size);
                size = 0;
            }
        }
        return res;
    }
}
