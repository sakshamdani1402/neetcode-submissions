class Solution {
    private void initMap(HashMap<Character, Integer> hm, String t) {
        int n = t.length();
        hm.clear();
         for(int i = 0; i < n; i++) {
            char x = t.charAt(i);
            hm.put(x, hm.getOrDefault(x, 0) + 1);
        }
    }

    public String minWindow(String s, String t) {
        int n = t.length();
        String result = "";
        // HashSet<Character> hash;
        HashMap<Character, Integer> hm = new HashMap<Character, Integer>();
        initMap(hm, t);
        // System.out.println(hm);

        int i = 0, j = 0;
        while(j < s.length()) {
            int countInMap = hm.getOrDefault(s.charAt(i), 0);
            if(countInMap <= 0) {
                i++;
                j++;
                continue;
            }
            String res = "";
            res += s.charAt(i);
            int counter = 1;
            hm.put(s.charAt(i), countInMap - 1);
            j++;
            while(j <= s.length()) {
                if(j == s.length() && counter !=  n) {
                    break;
                }
                if(counter == n) {
                    if(result == "" || res.length() < result.length()) {
                        result = res;
                System.out.println(String.format("Found substr : %s", res));

                    }
                    initMap(hm, t);
                    break;
                }
                char curr = s.charAt(j);
                int currCount = hm.getOrDefault(curr, 0);
                res += curr;
                System.out.println(String.format("%s : %d", res, counter));
                if(currCount > 0) {
                    hm.put(curr, currCount - 1);
                    counter++;
                }
                j++;
            }
            i++;
            j=i;
        }
        return result;
    }
}
