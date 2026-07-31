public class KthLargest {
    PriorityQueue<int, int> pq;
    int _k;
    public KthLargest(int k, int[] nums) {
        _k = k;
        pq = new();
        foreach(int num in nums) {
            pq.Enqueue(num, num);
            if(pq.Count > _k) {
                pq.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val,val);
        if(pq.Count > _k) {
            pq.Dequeue();
        }
        return pq.Peek();
    }
}
