public class Solution {
    private double dist(int x, int y)
    {
        return Math.Sqrt(x*x + y*y);
    }

    public struct Pair
    {
        public int x {get; set;}
        public int y {get; set;}
        public Pair(int _x, int _y) {
            x = _x;
            y = _y;
        }
    }
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<Pair, double> pq = new(Comparer<double>.Create((x, y) => y.CompareTo(x)));

        foreach(int[] pair in points) {
            double distance = dist(pair[0], pair[1]);
            pq.Enqueue(new Pair(pair[0], pair[1]), distance);

            if(pq.Count > k) {
                pq.Dequeue();
            }
        }

        int[][] result = new int[k][];
        for(int i = 0; i < k; i++) {
            Pair p = pq.Dequeue();
            result[i] = new int[] {p.x, p.y};
        }
        return result;
    }
}
