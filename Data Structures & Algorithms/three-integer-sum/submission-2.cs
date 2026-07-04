public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new();
        for(int i = 0; i < nums.Length-2; i++ ) {
            if(nums[i] > 0) break;
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int j = i+1, k=nums.Length-1;
            while(j < k) {
                int target = nums[i] + nums[j] + nums[k];

                if(target == 0) {
                    result.Add(new List<int>() {nums[i] , nums[j] , nums[k]});
                    while(j<k && nums[j] == nums[j+1]) j++;
                    while(j<k && nums[k-1] == nums[k]) k--;

                    j++; k--;
                }
                else if(target > 0) {
                    k--;
                }
                else {
                    j++;
                }
            }
        }
        return result;
    }
}
