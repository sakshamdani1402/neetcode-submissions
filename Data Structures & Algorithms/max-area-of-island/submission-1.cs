public class Solution {
    int row;
    int col;

     private int dfs(int[][] g, int i, int j) {
        if(i < 0 || i >= row || j < 0 || j >= col) {
            return 0; 
        }
        if(g[i][j] == 0) {
            return 0;
        }
        g[i][j] = 0;
        return 1 + dfs(g, i+1, j) + dfs(g, i-1, j) + dfs(g, i, j + 1) + dfs(g, i, j - 1);
    }

    public int MaxAreaOfIsland(int[][] grid) {
        row = grid.Length;
        col = grid[0].Length;
        int maxArea = 0;
        
        for(int i=0; i < row; i ++) {
            for(int j = 0; j < col; j++) {
                if(grid[i][j] == 0) continue;
                maxArea = Math.Max(dfs(grid, i, j), maxArea);
            }
        }

        return maxArea;
    }
}
