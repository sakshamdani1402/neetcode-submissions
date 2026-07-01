class Solution {
    bool isNotAlphanumeric(char c) {
        return !isalnum(c);
    }
public:
    bool isPalindrome(string s) {
        int i=0, j=s.size() -1;
        while(i<j) {
            if(isNotAlphanumeric(s[i])) i++;
            else if(isNotAlphanumeric(s[j])) j--;
            else if(tolower(s[i]) == tolower(s[j])) i++,j--;
            else return false;
        }
        return true;
    }
};
