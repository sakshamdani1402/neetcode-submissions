class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int n = nums.size(), product = 1;
        vector<int> result (n, 1);
        for(int i=1; i< n; i++) {
            int x = product * nums[i-1];
            result[i] = x;
            product = x; 
        }
        //[1,1,12,8]
        //[1,2,4,6]
        product = 1;
        for(int i = n-1; i>=0; i--) {
            int x = product * result[i];
            result[i] = x;
            product*= nums[i];
        }
        return result;
    }
};
