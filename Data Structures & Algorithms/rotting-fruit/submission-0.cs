public struct Node
{
    public int x;
    public int y;

    public Node(int _x, int _y){
        x = _x;
        y = _y;
    }
}
public class Solution {
    public int OrangesRotting(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int fresh = 0;
        int time = 0;
    
        Queue<Node> q = new();
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] == 2) {
                    q.Enqueue(new Node(i,j));
                }
                if(grid[i][j] == 1) {
                    fresh++;
                }
            }
        }
        
        List<Node> dirs = new() {new Node(-1, 0), new Node(1,0), new Node(0, 1), new Node(0, -1)};
        while(q.Count > 0 && fresh > 0) {
            int levelCount = q.Count;
            for(int i = 0; i < levelCount; i ++) {

                Node rottenFruit = q.Dequeue();
            int row = rottenFruit.x;
            int col = rottenFruit.y;

                foreach(Node dir in dirs) {
                int r = row + dir.x;
                int c = col + dir.y;

                if(r < 0 || r >= n || c >= m || c < 0 || grid[r][c] != 1) {
                    continue;
                } 
                
                grid[r][c] = 2;
                fresh--;
                q.Enqueue(new Node(r, c));
                }
            }
            time++;
        }

        return fresh <= 0 ? time : -1;

    }
}
