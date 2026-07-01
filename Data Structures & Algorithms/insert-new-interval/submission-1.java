class Solution {
    private void print(int x, int y) {
        System.out.println(String.format("%d, %d", x, y));
    }
    
    public int[][] insert(int[][] intervals, int[] newInterval) {
        ArrayList<int[]> res = new ArrayList<>();
        int x = newInterval[0];
        int y = newInterval[1];
        boolean merged = false;

        for (int[] curr : intervals) {
            int x0 = curr[0];
            int y0 = curr[1];

            // If the current interval ends before the newInterval starts, just add it to the result.
            if (y0 < x) {
                res.add(curr);
            } 
            // If the current interval starts after the newInterval ends, add the newInterval first (only once).
            else if (x0 > y) {
                if (!merged) {
                    res.add(new int[] {x, y});  // Add the newInterval at the correct position.
                    merged = true;
                }
                res.add(curr);
            } 
            // If the current interval overlaps with the newInterval, merge them.
            else {
                x = Math.min(x, x0);  // Update the starting point of the merged interval.
                y = Math.max(y, y0);  // Update the ending point of the merged interval.
            }
        }

        // If the newInterval was not added during the loop (because it's still waiting to be inserted), add it now.
        if (!merged) {
            res.add(new int[] {x, y});
        }

        return res.toArray(new int[res.size()][]);
    }
}
