class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
    unordered_set<char> seen;
    vector<unordered_set<char>> blockSeen(9);
        // validate row
        for(int i=0; i< 9; i++) {
            for(char j : board[i]) {
                if(j == '.') continue;
                if(seen.find(j) != seen.end()) {
                    return false;
                }
                seen.insert(j);
            }
            seen.clear();
        }
        //validate column
        for(int i = 0; i < 9; i++) {
            for(int j =0; j< 9; j++) {
                char x = board[j][i]; 
                if(x == '.') continue;
                if(seen.find(x) != seen.end()) {
                return false;
                }
                seen.insert(x);
            }
            seen.clear();
        }
        
        for(int i = 0; i < 9; i++) {
            for(int j =0; j< 9; j++) {
                char x = board[i][j];
                if(x == '.') continue;
                int blockNo = (i/3)*3 + j/3;
                if(blockSeen[blockNo].find(x) != blockSeen[blockNo].end()) {
                    return false;  
                }
                blockSeen[blockNo].insert(x);
            }
        }

        return true;
    }
};
