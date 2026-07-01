class Solution {
    List<List<Integer>> res = new ArrayList<>();
    int n = 0;
    private void backtrack(int[] nums, ArrayList<Integer> arr, int i) {
        if(i < 0) {
            res.add(new ArrayList<>(arr));
            return;
        }
        arr.add(nums[i]);
        backtrack(nums, arr, i-1);
        arr.remove(arr.size() - 1);
        backtrack(nums, arr, i - 1);
    }
    public List<List<Integer>> subsets(int[] nums) {
        if(nums.length == 0) {
            return res;
        }
        n = nums.length;
        backtrack(nums, new ArrayList<Integer>() ,n-1);
        return res;
    }
}
