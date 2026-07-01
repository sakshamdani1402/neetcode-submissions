class Solution {
  long long calcHours(vector<int>& arr, int mid) {
        long long h = 0;
        for(int i : arr) {
            h += ceil((double)i/(double)mid);
        }
        return h;
    }
public:
    int minEatingSpeed(vector<int>& piles, int h) {
       int maxBananas = INT_MIN;
        for(int i : piles) maxBananas = max(i, maxBananas);

        int result = maxBananas;
        int l = 1, r = maxBananas;
        while(l <= r) {
            int mid = l + (r-l)/2;
            long long hours = calcHours(piles, mid);
            if(hours <= h) {
                result = min(result, mid);
                r = mid-1;
            }
            else l = mid + 1;
        }

        return result;
    }
};
