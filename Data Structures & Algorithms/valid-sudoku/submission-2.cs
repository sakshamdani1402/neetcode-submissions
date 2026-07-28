public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //key is index or row/row/block
        Dictionary<int, HashSet<char>> row = new();
        Dictionary<int, HashSet<char>> col = new();
        Dictionary<int, HashSet<char>> block = new();

         for(int i = 0; i < 9 ; i++) {
            for(int j = 0; j < 9; j ++) {
                if(board[i][j] == '.') {
                    continue;
                }
                int blockIdx = (i/3) * 3 + (j/3);
                if(!row.ContainsKey(i)) row[i] = new HashSet<char>();
                if(!col.ContainsKey(j)) col[j] = new HashSet<char>();
                if(!block.ContainsKey(blockIdx)) block[blockIdx] = new HashSet<char>();
                
                char num = board[i][j];
                if(row[i].Contains(num) || col[j].Contains(num) || block[blockIdx].Contains(num))
                {
                    return false;
                }
                row[i].Add(num);
                col[j].Add(num);
                block[blockIdx].Add(num);
            }
         }
         return true;
    }
}
