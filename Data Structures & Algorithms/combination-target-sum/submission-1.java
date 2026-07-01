class Solution {
    List<List<Integer>> res = new ArrayList<>();
    private void dfs(int[] nums, ArrayList<Integer> arr, int i, int target) {
        System.out.println("________");
        System.out.println("current target " + target + " "+ i);
        if(i < 0 || target < 0) {
            return;
        }
        if(target == 0) {
            res.add(new ArrayList<Integer>(arr));
            return;
        }
        arr.add(nums[i]);
        System.out.println("adding " +nums[i] + " at " + i);
        System.out.print("elem of arr: " );
        for(int k :  arr) { System.out.print(" " + k) ;}
        dfs(nums, arr, i , target - nums[i]);

        System.out.println("removing " +nums[i] + " at " + i);
        arr.remove(arr.size() - 1);
        for(int k :  arr) { System.out.print("elem of arr: " + k) ;}
        dfs(nums, arr, i - 1, target);
    }
    public List<List<Integer>> combinationSum(int[] nums, int target) {
        if(nums.length == 0) return new ArrayList<>();
        dfs(nums, new ArrayList<Integer>(), nums.length - 1, target);
        return res;
    }
}
