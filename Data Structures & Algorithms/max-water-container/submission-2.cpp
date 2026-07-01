class Solution {
public:
    int maxArea(vector<int>& heights) {
        int area = 0;
        int l = 0, r = heights.size() - 1;
        int lmax = 0, rmax=0;
        while(l < r) {
            lmax = max(lmax, heights[l]);
            rmax = max(rmax, heights[r]);
            area = max(area, (r - l) * min(lmax, rmax));
            if(lmax < rmax) l++;
            else r--;
        }
        return area;
    }
};
