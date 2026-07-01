public class Solution {
    public class Pair
    {
        public int key;
        public int value;
        public Pair(int _key, int _value){
            key = _key;
            value = _value;
        }
    }
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new ();
        foreach(int num in nums) {
            if(freq.ContainsKey(num)) {
                freq[num]++;
            } else {
                freq[num] = 0;
            }
        }
        var maxHeap = new PriorityQueue<Pair,int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach( var kvp in freq) {
            maxHeap.Enqueue(new Pair(kvp.Key, kvp.Value), kvp.Value);
        }

        var res = new int[k];
        for(int i = 0; i<k;i++) {
            res[i] = maxHeap.Dequeue().key;
        }
        return res;
    }
}
