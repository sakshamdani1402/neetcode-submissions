public class Solution {
    public void Rotate(int[][] matrix) {
        Array.Reverse(matrix);
        for(int i=0; i<matrix.Length; i++) {
            for(int j = i; j < matrix[0].Length; j++) {
                int temp = matrix[j][i];
                matrix[j][i] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }
    }
}

// 1 2 3
// 4 5 6
// 7 8 9 

// 7 4 1
// 8 5 2
// 9 6 3

// 7 8 9
// 4 5 6
// 1 2 3

// 7 4 1
// 8 5 2 
// 9 6 3