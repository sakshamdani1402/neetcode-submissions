class Solution {
    public int[] maxSlidingWindow(int[] nums, int l) {
        int n = nums.length;
        ArrayList<Integer> result = new ArrayList<Integer>();
        int j = 0;
        int max = Integer.MIN_VALUE;
        while(j < l) {
            max = Math.max(max, nums[j]);
            j++;
        }
        int i = 0; j--;
        result.add(max);
        System.out.println(result);
        System.out.println("in loop");
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
            result.add(max);
                j++;
                i++;
            System.out.println(String.format("adding : %d", max));
            System.out.println(result);
        }
        int len = result.size();
        int[] arr = new int[len];
        for(i = 0; i < len; i++) {
            arr[i] = result.get(i);
        }
        return arr;
    }
}
