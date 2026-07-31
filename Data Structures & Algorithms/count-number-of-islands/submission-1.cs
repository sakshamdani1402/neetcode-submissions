public class Solution {
    int count = 0;
    int row ;
    int col;

    private void dfs(char[][] g, int i, int j) {
        if(i < 0 || i >= row || j < 0 || j >= col) {
            return; 
        }
        if(g[i][j] == '0') {
            return;
        }
        g[i][j] = '0';
        dfs(g, i+1, j);
        dfs(g, i-1, j);
        dfs(g, i, j + 1);
         dfs(g, i, j - 1);
    }
    public int NumIslands(char[][] grid) {
        row = grid.Length;
        col = grid[0].Length;
        
        for(int i=0; i < row; i ++) {
            for(int j = 0; j < col; j++) {
                if(grid[i][j] == '0') continue;

                count ++;
                dfs(grid, i, j);
            }
        }

        return count;
    }
}
