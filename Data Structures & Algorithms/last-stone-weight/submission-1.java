class Solution {
    public int lastStoneWeight(int[] stones) {
        PriorityQueue<Integer> pq = new PriorityQueue<Integer>(Collections.reverseOrder());
        for(int stone :  stones) {
            pq.add(stone);
        }
        while(!pq.isEmpty() && pq.size() != 1) {
            int num = pq.peek();
            pq.poll();
            int num2 = pq.peek();
            pq.poll();
            if(num != num2) {
                pq.add(num - num2);
            }
        }
        return pq.isEmpty() ? 0 : pq.peek();
    }
}
