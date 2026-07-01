class Solution {
    private void dfs(int i, int j, char[][] grid) {
        int n = grid.length;
        int m = grid[0].length;
        if(i < 0 || i >= n) return;
        if(j < 0 || j >= m) return;
        if(grid[i][j] == '0') return;
        grid[i][j] = '0';
        dfs(i + 1, j, grid);
        dfs(i, j + 1, grid);
        dfs(i - 1 , j, grid);
        dfs(i , j - 1, grid);
    }
    public int numIslands(char[][] grid) {
        int count = 0;
        for(int i = 0; i < grid.length; i++) {
            for(int j = 0; j < grid[0].length; j++) {
                if(grid[i][j] == '0') continue;
                dfs(i , j , grid);
                count += 1; 
            }
        }
        return count;
    }
    
}
