public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        if(nums[0] <= nums[n-1]) {
            return nums[0];
        }

        int l = 0, r = n-1;
        while(l <= r) {
            int mid = l + (r - l)/2;
            if(mid < r && nums[mid] > nums[mid+1]) {
                return nums[mid+1];
            } else if (mid > l && nums[mid] < nums[mid-1]){
               return nums[mid];
            }
            if(nums[mid] > nums[r]) l = mid + 1;
            else r = mid - 1;
        }
        return -1;
    }
}
