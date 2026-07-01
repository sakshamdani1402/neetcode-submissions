class Solution {
    int maxLen = 0;
    int startIndex = 0;

    private void expand(String s, int left, int right) {
        while(left >= 0 && right < s.length()){
            if(s.charAt(left) != s.charAt(right)) {
                break;
            }
            left--; right++;
        }
        if(right - left - 1 > maxLen) {
            maxLen = right - left - 1;
            startIndex = left + 1;
        }
    }

    public String longestPalindrome(String s) {
        if(s == "") {
            return "";
        }
        for(int i = 0; i < s.length(); i++) {
            expand(s,i,i);
            expand(s,i,i+1);
        }
        return s.substring(startIndex, startIndex + maxLen);
    }
}
