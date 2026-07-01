public class Pair
{
    public int position;
    public int speed;

    public Pair(int pos, int spee) {
        position = pos;
        speed = spee;
    }
}
public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<Pair> list = new();
        for(int i = 0; i < position.Length; i++) {
            list.Add(new Pair(position[i], speed[i]));
        }
        list.Sort((a, b) => b.position.CompareTo(a.position));
        int count = 1;
        double prev_time = (double)(target - list.First().position)/list.First().speed;
        for(int i = 1; i < position.Length; i++) {
            double curr_time = (double)(target - list[i].position)/list[i].speed;
            if(prev_time < curr_time) {
                prev_time = curr_time;
                count += 1;
            }
        }
        return count;
    }
}
