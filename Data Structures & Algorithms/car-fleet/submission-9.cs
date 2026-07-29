public class Solution {

    public struct Pair
    {
        public int pos {get; set;}
        public int speed {get; set;}

        public Pair(int posi, int pace)
        {
            pos = posi;
            speed = pace;
        }
    }
    public int CarFleet(int target, int[] position, int[] speed) {
        List<Pair> list = new();
        for(int i=0; i<position.Length; i++)
        {
            list.Add(new Pair(position[i], speed[i]));
        }
        list.Sort((a,b) => b.pos.CompareTo(a.pos));
        int result = 0;
        double maxTime = 0;
    
        for(int i = 0; i < list.Count; i++) {
            double timeTaken = (double)(target - list[i].pos)/list[i].speed;
            if(timeTaken > maxTime) {
                result++;
                maxTime = timeTaken;
            }
        }

        return result;
    }
}
