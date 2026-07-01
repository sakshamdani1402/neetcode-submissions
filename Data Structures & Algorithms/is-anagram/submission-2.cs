public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<char,int> visited = new();
        foreach(char x in s)
        {
            int count = visited.GetValueOrDefault(x, 0);
            visited[x] = count + 1;
        }
        foreach(char x in t)
        {
            int count = visited.GetValueOrDefault(x);
            if(count <= 0){
                return false;
            }
            visited[x]--;
        }
        return true;
    }
}
