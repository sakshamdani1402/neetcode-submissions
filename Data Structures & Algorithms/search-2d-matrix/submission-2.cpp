class Solution {
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        int row = matrix.size(), col = matrix[0].size();
        int size = row * col;
        int l = 0, r = size - 1;

        while(l <= r) {
            int mid = l + (r-l)/2;
            int num = matrix[mid/col][mid%col];
            if(target == num) {
                return true;
            }
            else if(target < num) {
                r = mid - 1;
            }
            else l = mid + 1;
        }
        return false;
    }
};
