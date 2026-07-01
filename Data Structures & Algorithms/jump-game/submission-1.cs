public class Solution {
    public bool CanJump(int[] nums) {
        if(nums.Length <= 1) {
            return true;
        }
        if(nums[0] == 0) {
            return false;
        }
        int target = nums.Length - 1;
        // List<bool> canJump = Enumerable.Repeat(false, nums.Length).ToList<bool>();
        // canJump[target] = true;
        for(int i = target - 1; i >= 0 ; i--) {
            if(nums[i] + i >= target) {
                target = i;
            }
        }
        return target == 0;
    }
}
