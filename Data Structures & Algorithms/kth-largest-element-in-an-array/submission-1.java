class Solution {
    public int findKthLargest(int[] nums, int k) {
        PriorityQueue<Integer> pq = new PriorityQueue<Integer>((a, b) -> Integer.compare(a, b));
        for(int i : nums) {
            pq.add(i);
            System.out.println("number added"+ i + " top of the q = "+ pq.peek());
            if(pq.size() > k){ pq.poll();}
        }
        return pq.isEmpty() ? 0 : pq.peek();
    }
}
