class Solution {
    private class Coordinate {
        private int x;
        private int y;
        private int dist;
        public Coordinate(int x,int y) {
            this.x = x;
            this.y = y;
            this.dist = x*x + y*y;
        }
        public int getDist() {
            return dist;
        }
        public int getX() {
            return x;
        }
        public int getY() {
            return y;
        }
    }
    public int[][] kClosest(int[][] points, int k) {
        PriorityQueue<Coordinate> pq = new PriorityQueue<Coordinate>((c1, c2) -> Integer.compare(c2.getDist(), c1.getDist()));
        for(int[] point : points) {
            pq.add(new Coordinate(point[0], point[1]));
            if(pq.size() > k) {
                pq.poll();
            }
        }
        if(pq.isEmpty()) {
            return new int[0][0];
        }
        int[][] result = new int[k][2];
        int i = 0;
        while(!pq.isEmpty()) {
            Coordinate c = pq.peek();
            pq.poll(); 
            int[] coor = new int[] {c.getX(), c.getY()};
            result[i] =  coor;
            i++;
        }
        return result;
    }
}
