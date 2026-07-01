class Solution {
    public int dfs(int i, int j, int[][] grid ) {
        int n = grid.length;
        int m = grid[0].length;
        if(i < 0 || i >= n || j < 0 || j >= m || grid[i][j] != 1) {
            return 0;
        }
        grid[i][j] = 0;
        int calcArea = 1 +
        dfs(i+1, j, grid) +
            dfs(i-1, j, grid) +
            dfs(i, j + 1, grid) +
            dfs(i, j - 1, grid);
        return calcArea;
    }

    public int maxAreaOfIsland(int[][] grid) {
        int n = grid.length;
        int m = grid[0].length;
        int maxarea = 0;
        for(int i = 0; i<n;i++) {
            for(int j = 0; j < m; j++){
                if(grid[i][j] == 0) {
                    continue;
                }
                maxarea = Math.max(dfs(i,j,grid), maxarea);
            }
        }
        return maxarea;
    }
}
