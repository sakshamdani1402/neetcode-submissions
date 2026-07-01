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
        product = 1;
        for(int i = n-1; i>=0; i--) {
            result[i] *= product;
            product*= nums[i];
        }
        return result;
    }
};
