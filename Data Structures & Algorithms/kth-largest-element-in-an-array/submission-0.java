class Solution {
    public int findKthLargest(int[] nums, int k) {
        PriorityQueue<Integer> pq = new PriorityQueue<Integer>((a, b) -> Integer.compare(a, b));
        for(int i : nums) {
            pq.add(i);
            if(pq.size() > k){ pq.poll();}
            System.out.println("number added"+ i + " top of the q = "+ pq.peek());
        }
        return pq.isEmpty() ? 0 : pq.peek();
    }
}
// [2] , 2
// [2,3], 2
// [3,2,1], 1
// [2]
