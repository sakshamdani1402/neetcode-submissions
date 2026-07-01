class Solution {
    List<List<Integer>> subsets = new ArrayList<>();
    private void find(int[] nums, int begin, ArrayList<Integer> subset) {
        subsets.add(new ArrayList<Integer>(subset));
        for(int i = begin; i >= 0; i--) {
            if(i < begin && nums[i] == nums[i+1]) continue;
                subset.add(nums[i]);
                find(nums, i-1, subset);
                subset.remove(subset.size() - 1);
        }
    }
    public List<List<Integer>> subsetsWithDup(int[] nums) {
        if(nums.length == 0) {
        subsets.add(new ArrayList<Integer>());
            return subsets;
        }
        int[] sortedArray = Arrays.stream(nums)
                                  .boxed()
                                  .sorted((a, b) -> b - a)
                                  .mapToInt(Integer::intValue)
                                  .toArray();
        for(int i: sortedArray) System.out.print(i);
        find(sortedArray, nums.length - 1, new ArrayList<Integer>());
        return subsets;
    }
}
