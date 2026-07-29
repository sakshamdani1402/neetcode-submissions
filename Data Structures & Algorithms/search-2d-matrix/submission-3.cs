public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length * matrix[0].Length;
        int i = 0, j = n - 1;
        while(i<=j) {
            int mid = (i+j)/2;
            int row = mid/matrix[0].Length;
            int col = mid % matrix[0].Length;

            if(matrix[row][col] == target) {
                return true;
            } else if(matrix[row][col] > target) {
                j = mid - 1;
            } else {
                i = mid + 1;
            }
        }
        return false;
    }
}
