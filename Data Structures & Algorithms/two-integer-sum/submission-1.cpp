class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int,int> index_map;

        for(int j = 0; j < nums.size(); j++) {
            int y = target - nums[j];
            if(index_map.count(y)) {
                if(j < index_map[y])
                return vector<int> {j, index_map[y]};
                return vector<int> {index_map[y], j};
            } 
            index_map[nums[j]] = j;
        }
        return vector<int> {};
    }
};
