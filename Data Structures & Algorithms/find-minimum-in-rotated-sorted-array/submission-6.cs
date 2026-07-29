public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        if(n == 1) {
            return nums[0];
        }   
        if(nums[0] < nums[n-1]) {
            return nums[0];
        }

        int i = 0, j = n-1;
        while(i <= j) {
            int mid = i + (j - i)/2;
            if(mid < j && nums[mid] > nums[mid + 1]) {
                return nums[mid + 1];
            }
            else if(mid > i && nums[mid] < nums[mid - 1]) {
                return nums[mid];
            }

            if(mid < j && nums[mid] < nums[j]) {
                j = mid - 1;
            } else if( mid > i && nums[mid] > nums[i]) {
                i = mid + 1;
            }
        }
        return -1;
    }
}
