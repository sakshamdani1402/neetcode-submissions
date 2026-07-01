public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new();
        foreach (int num in nums) {
            if (count.ContainsKey(num)) count[num]++;
            else count[num] = 1;
        }
        
        PriorityQueue<int, int> queue = new(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach(var kvp in count)
        {
            queue.Enqueue(kvp.Key, kvp.Value);
        }
        int[] res = new int[k];
        for(int i = 0; i < k; i++)
        {
            res[i] = queue.Dequeue();
        }
        return res;
    }
}
