class Solution {
    HashMap<Integer, Integer> memo = new HashMap<>();
    public int find(int[] coins, int amount)
    {
        if(amount == 0) {
            return 0;
        }
        if(memo.containsKey(amount)) {
            return memo.get(amount);
        }
        int res = 10000000;
        for(int coin : coins){
            if(amount - coin < 0) continue;
            res = Math.min(res, 1 + find(coins, amount - coin));
        }
        memo.put(amount, res);
        return res;
    }
    public int coinChange(int[] coins, int amount) {
        if(amount == 0) {
            return 0;
        }
        int res = find(coins, amount);
        return res >= 10000000 ? -1 : res;
    }
}
