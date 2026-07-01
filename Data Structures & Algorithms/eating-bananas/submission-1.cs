public class Solution {
    private int getHours (int[] piles, int rate) {
        int hours = 0;
        foreach(int i in piles) {
            hours += (int)Math.Ceiling((double)i/rate);
        }
        return hours;
    }
    public int MinEatingSpeed(int[] piles, int h) {
        int maxBananas = 0;
        foreach(int i in piles)
        {
            maxBananas = Math.Max(maxBananas, i);
        }
        Console.WriteLine(maxBananas);
        int low = 1, high = maxBananas;
        int minRate = maxBananas;
        while(low <= high) {
            int mid = low + (high - low)/2;
            int hours = getHours(piles, mid);
            if(hours > h) {
                low = mid + 1;
            }
            else {
                minRate = Math.Min(minRate, mid);
                high = mid - 1;
            }
        }
        return minRate;
    }
}
