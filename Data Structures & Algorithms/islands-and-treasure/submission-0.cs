public struct Node 
{
    public int x;
    public int y;

    public Node(int _x, int _y) {
        x = _x;
        y = _y;
    }
}
public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        if(grid == null) {
            return;
        }
        Queue<Node> q = new();

        for(int i=0; i<grid.Length; i++) {
            for(int j=0; j<grid[0].Length; j++) {
                if(grid[i][j] != 0) continue;
                q.Enqueue(new Node(i, j));
            }
        }
        List<Node> dirs = new() {new Node(-1, 0), new Node(1,0), new Node(0, 1), new Node(0, -1)};
        while(q.Count > 0) {
            Node node = q.Dequeue();
            foreach(Node dir in dirs) {
                int row = node.x + dir.x;
                int col = node.y + dir.y;
                if(row >= grid.Length || row < 0 || col >= grid[0].Length || col < 0 || grid[row][col] != 2147483647) {
                    continue;
                }
                q.Enqueue(new Node(row, col));
                grid[row][col] = grid[node.x][node.y] + 1;
            }
        }
    }
}
