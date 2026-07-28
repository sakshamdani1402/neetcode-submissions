public class Solution {
    private Dictionary<int, int> seen = new ();

    private int Get(int num)
    {
        return seen.GetValueOrDefault(num);
    }

    public int LongestConsecutive(int[] nums) {
        int result = 0;
        for(int i = 0; i < nums.Length; i ++ ) {
            if(seen.ContainsKey(nums[i])) {
                continue;
            }
            int lcs = Get(nums[i]-1) + 1 + Get(nums[i] + 1);
            seen[nums[i]] = lcs;
            seen[nums[i]- Get(nums[i] - 1)] = lcs;
            seen[nums[i] + Get(nums[i] + 1)] = lcs; 
            result = Math.Max(result, lcs);
        }
        return result;
    }
}
