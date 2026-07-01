/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

class Solution {
    public int minMeetingRooms(List<Interval> intervals) {
        intervals.sort((a, b) -> a.start - b.start);
        PriorityQueue<Integer> heap = new PriorityQueue<>();
        for(int i = 0; i < intervals.size(); i++) {
            if(!heap.isEmpty() && intervals.get(i).start >= heap.peek()) {
                heap.poll();
            }
            heap.add(intervals.get(i).end);
        }
        return heap.size();
    }
}
