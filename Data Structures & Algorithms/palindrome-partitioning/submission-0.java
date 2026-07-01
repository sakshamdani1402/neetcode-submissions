 class Solution {
    List<List<String>> res = new ArrayList<>();
    List<String> list = new ArrayList<>();
    private boolean isPalindrome(String s, int i, int j) {
        while(i <= j) {
            if(s.charAt(i) != s.charAt(j)) {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
    private void partition(String s, int begin) {
        if(begin >= s.length()) {
            res.add(new ArrayList<>(list));
        }
        for(int i = begin; i < s.length(); i++) {
            if(isPalindrome(s, begin, i)) {
                list.add(s.substring(begin, i+1));
                partition(s, i+1);
                list.remove(list.size() - 1);
            }
        }
    }

    public List<List<String>> partition(String s) {
            partition(s, 0);
            return res;
        }
}
