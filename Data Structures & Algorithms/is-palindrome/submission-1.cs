public class Solution {
    private bool IsAlphaNum(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
    }

    public bool IsPalindrome(string s) {
        int i=0, j = s.Length - 1;
        while (i <= j) {
            if(!IsAlphaNum(s[i])) {
                i++;
                continue;
            }
            else if(!IsAlphaNum(s[j])) {
                j--;
                continue;
            } else if (char.ToLower(s[i]) != char.ToLower(s[j])) {
                return false;
            } else {
                i++;
                j--;
            }
        }
        return true;
    }
}
