class MedianFinder {
    PriorityQueue<Integer> pq;
    public MedianFinder() {
        pq = new PriorityQueue<Integer>();
    }
    
    public void addNum(int num) {
        pq.add(num);
    }
    
    public double findMedian() {
        int size = pq.size();
        boolean isEven = size%2 == 0;
        int popCnt = (int)(Math.floor((double)(pq.size()) / 2) + 1.0);
        ArrayList<Integer> arr = new ArrayList<>();
        System.out.println("_____" + popCnt + "___");
        while(!pq.isEmpty() && popCnt > 0 ) {
            int x = pq.poll();
            System.out.println(x);
            arr.add(x);
            popCnt --;
        }
        pq.addAll(arr);
        int n = arr.size();
        if(isEven) {
            return (double)(arr.get(n-1) + arr.get(n-2))/2;
        } else return arr.get(n-1);
    }
}

// 1 2 3 4 5 6 7
// 7 - 4 = 3 + 1
// 1 2 3 4 5 6
// 6 - 3 = 3 + 1