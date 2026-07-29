public class Solution {
    private int GetHours(int[] piles, int k)
    {
        int sum = 0;
        foreach(int pile in piles)
        {
            sum += (int)Math.Ceiling((double)pile/k);
        }
        return sum;
    }
    public int MinEatingSpeed(int[] piles, int h) {
        int i = 1, j = piles.Max();
        int minK = j;
        while(i <= j) {
            int mid = i + (j-i)/2;
            int hours = GetHours(piles, mid);
            if(hours > h) {
                i = mid + 1;
                continue;
            }
            minK = mid;
            j = mid - 1;
        }
        return minK;
    }
}
