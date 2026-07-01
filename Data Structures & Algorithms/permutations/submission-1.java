class Solution {
    private List<List<Integer>> res = new ArrayList<>();
    private void swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    private void dfs(int[] nums, int begin) {
        if(begin < 0) {
            res.add(Arrays.stream(nums).boxed().collect(Collectors.toCollection(ArrayList::new)));
            return;
        }
        for(int i = begin; i>= 0; i--) {
            swap(nums, i, begin);
            dfs(nums, begin - 1);
            swap(nums, i, begin);
        }
    }

    public List<List<Integer>> permute(int[] nums) {
        if(nums.length == 0) {
            return res;
        }
        dfs(nums, nums.length - 1);
        return res;
    }
}

// 1 2 3
// 2 1 3
// 1 2 3
// 1 3 2
//
