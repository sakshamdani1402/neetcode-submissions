public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = 0, fast = 0;
        while(true) {
            fast = nums[nums[fast]];
            slow = nums[slow];
            if(slow == fast) break;
        }
        slow = 0;
        while(slow != fast) {
            fast = nums[fast];
            slow = nums[slow];
        }
        return slow;
    }
}
