public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new();
        dict.Add(target-nums[0],0);
        for(int i=1;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])) return [dict[nums[i]],i];
            dict.Add(target-nums[i],i);
        }
        return [0,0];
    }
}
