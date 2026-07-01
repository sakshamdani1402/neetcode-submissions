public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        int n = hand.Length;
        if(n % groupSize != 0) return false;
        Dictionary<int, int> dict = new();
        foreach(int num in hand) {
            if(!dict.ContainsKey(num)) {
                dict.Add(num, 0);
            }
            dict[num]++;
        }
        // 1 22 33 44 5
        Array.Sort(hand);
        for(int i = 0; i < n; i++) {
            if(dict.ContainsKey(hand[i]) && dict[hand[i]] > 0) {
                for(int j = 0; j < groupSize; j++) {
                    int num = hand[i] + j;
                    if(!dict.ContainsKey(num) || dict[num] <= 0) {
                        return false;
                    }
                    dict[num]--;
                }
            }
        }
        return true;
    }
}
