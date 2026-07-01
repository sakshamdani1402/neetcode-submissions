public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
        if(n <= 1) return true;
        if(nums[0] == 0) return false;
        int goal = n -1;
        for(int i = n - 1; i >=0; i--) {
            if(nums[i] + i >= goal) {
                goal = i;
            }
        }
        return 0 == goal;
    }
}
