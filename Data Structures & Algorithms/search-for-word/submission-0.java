class Solution {
    private int row;
    private int col;
    private char[][] grid;
    private String x;
    private boolean backtrack(int i, int j, int curr) {
        if(curr > x.length() - 1) {
            return true;
        }
        if(i < 0 || j < 0 || i >= row || j >= col || grid[i][j] != x.charAt(curr)) {
            return false;
        }

        grid[i][j] = '#';
            boolean res = backtrack(i+1,j,curr+1) 
            || backtrack(i-1,j,curr+1) 
            || backtrack(i, j+1, curr+1)
            || backtrack(i, j-1, curr+1);
        grid[i][j] = x.charAt(curr);
        return res;
    }
    public boolean exist(char[][] board, String word) {
        row = board.length;
        col = board[0].length;
        grid = board;
        x = word;
        boolean res = false;
        for(int i = 0; i<row; i++){
            for(int j = 0; j < col; j++){
                if(backtrack(i,j,0)) {
                    return true;
                }
            }
        }
        return res;
    }
}
