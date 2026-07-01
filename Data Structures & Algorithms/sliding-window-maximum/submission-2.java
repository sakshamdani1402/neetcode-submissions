class Solution {
    public int[] maxSlidingWindow(int[] nums, int l) {
        int n = nums.length;
        int[] result = new int[n-l+1];
        int j = 0;
        int max = Integer.MIN_VALUE;
        while(j < l) {
            max = Math.max(max, nums[j]);
            j++;
        }
        int i = 0; j--;
        result[i] = max;
        while(j < n - 1) {
            int incoming = nums[j+1];
            int outgoing = nums[i];
            if(incoming > max) {
                max = incoming;
            }
            else if(outgoing == max) {
                int localMax = Integer.MIN_VALUE;
                for(int k = i + 1; k <= j+1;k++){
                    localMax = Math.max(localMax, nums[k]);
                }   
                max = localMax;
            }
                j++;
                i++;
            result[i]= (max);
        }
        // int len = result.size();
        // int[] arr = new int[len];
        // for(i = 0; i < len; i++) {
        //     arr[i] = result.get(i);
        // }
        return result;
    }
}
