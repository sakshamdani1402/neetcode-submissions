class Solution {
public:
    int findMin(vector<int> &nums) {
        int n = nums.size();
        int l = 0, r = n - 1;

        if(nums[l] <= nums[r]) return nums[l];

        while(l<=r) {
            int mid = l + (r - l)/2;
            if(nums[mid] > nums[mid + 1]) return nums[mid+1];
            if(nums[mid] < nums[mid - 1]) return nums[mid];

            if(nums[mid] > nums[r]) l = mid + 1;
            else r = mid - 1;
        }
        return -1;
    }
};
