class Solution {
    private List<List<Integer>> res = new ArrayList<>();
    private List<Integer> combi = new ArrayList<>();
    private void backtrack(int[] nums, int begin, int target) {
        if(target == 0) {
            res.add(new ArrayList<>(combi));
            return;
        }
        for(int i = begin; i >= 0; i--) {
            if(i < begin && nums[i] == nums[i + 1]) {
                continue;
            }
            combi.add(nums[i]);
            backtrack(nums, i-1, target - nums[i]);
            combi.remove(combi.size() - 1);
        }
    }

    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
        if(candidates.length > 1){
            Arrays.sort(candidates);
        }
        backtrack(candidates, candidates.length - 1, target);
        return res;
    }
}
