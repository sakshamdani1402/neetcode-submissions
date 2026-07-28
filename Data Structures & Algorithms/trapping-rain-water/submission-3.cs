public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length - 1;
        int area = 0;
        int lmax = 0, rmax = 0;

        while (l <= r) {
            if (lmax < rmax) {
                lmax = Math.Max(lmax, height[l]);
                area += (lmax - height[l]);
                l++;
            } else {
                rmax = Math.Max(rmax, height[r]);
                area += (rmax - height[r]);
                r--;
            }
        }
        return area;
    }
}
