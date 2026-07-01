class Solution {
public:
    int trap(vector<int>& height) {
        int i=0, j=height.size()-1;
        int area = 0, lmax =0, rmax = 0;
        while(i <= j) {
            if(lmax < rmax) {
               lmax = max(lmax, height[i]);
               area += (lmax - height[i++]);
            }
            else {
                rmax = max(rmax, height[j]);
                area += (rmax - height[j--]);
            }
        }
        return area;
    }
};
// area = 9
//l=3
//r=3
//    0, 2, 0, 3, 1, 0, 1, 3, 2, 1
//  l             i  j            r
