public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach(int stone in stones) pq.Enqueue(stone, stone);

        while(pq.Count > 1) {
            int x = pq.Dequeue();
            int y = pq.Dequeue();

            if(x == y) continue;
            else {
                int stone = Math.Abs(y - x);
                pq.Enqueue(stone, stone);
            }
        }
        return pq.Count == 0? 0 : pq.Dequeue();
    }
}
