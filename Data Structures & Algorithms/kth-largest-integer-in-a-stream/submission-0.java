class KthLargest {
    PriorityQueue<Integer> q;
    int kth ;
    public KthLargest(int k, int[] nums) {
        this.q = new PriorityQueue<Integer>();
        for(int num : nums) {
            this.q.offer(num);
            if(this.q.size() > k) {
                this.q.poll();
            }
        }
        this.kth = k;
    }
    
    public int add(int val) {
        q.offer(val);
        if(q.size() > kth) {
            q.poll();
        }
        int num = q.peek();
        return num;
    }
}
