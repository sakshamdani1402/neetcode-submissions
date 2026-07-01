public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length - 1;
        int l = 0, r = 0;
        int count = 0;
        while(r < n) {
            int farthest = nums[r];
            for(int i = l; i <= r; i++) {
                farthest = Math.Max(farthest, nums[i] + i);
            }
            l = r + 1;
            r = farthest;
            count++;
        }
        return count;
    }
}
