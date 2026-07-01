class Solution {
public:
    int maxArea(vector<int>& heights) {
        int i=0, j= heights.size()-1;
        int area = 0;

        while(i < j) {
            int greaterHeight = min(heights[i], heights[j]);
            area = max(area, greaterHeight * (j-i));
            if(heights[i] < heights[j]) i++;
            else j--;
        }
        return area;
    }
};
