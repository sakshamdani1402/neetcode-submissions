public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if(gas.Sum() < cost.Sum()) {
            return -1;
        }
        int startStation = 0;
        int gasLeft = 0;
        for(int i = 0; i< gas.Length; i++) {
            gasLeft += (gas[i] - cost[i]);
            if(gasLeft < 0) {
                gasLeft = 0;
                startStation = i + 1;
            }
        }
        return startStation;
    }
}
