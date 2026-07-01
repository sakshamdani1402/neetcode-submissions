public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
       
        if(n <= 1) {
            return 0;
        }
        int l = 0, r = 0, minJumps = 0;
        while(r < n - 1) {
            int farthest = 0;
            for(int i = l; i<=r; i++) {
                farthest = Math.Max(farthest, nums[i] + i);
            }
            l = r + 1;
            r = farthest;
            minJumps++;
        }
        return minJumps;
    }
}
