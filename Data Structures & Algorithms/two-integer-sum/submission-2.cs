public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> vis = new();
        for(int i=0; i<nums.Length; i++) {
            if(vis.TryGetValue(target-nums[i], out int index)) {
                return new int[] {index, i};
            }
            vis[nums[i]] = i;
        }
        return null;
    }
}
