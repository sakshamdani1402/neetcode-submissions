public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool zeroth = false, oneth = false, twoeth = false;
        foreach(var triplet in triplets) {
            if(triplet[0] > target[0] || triplet[1] > target[1] || triplet[2] > target[2]) {
                continue;
            }
            if(triplet[0] == target[0]) zeroth = true;
            if(triplet[1] == target[1]) oneth = true;
            if(triplet[2] == target[2]) twoeth = true;
        }
        return zeroth && oneth && twoeth;
    }
}
