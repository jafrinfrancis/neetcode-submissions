public class Solution {
    public bool hasDuplicate(int[] nums) {
        int len = nums.Length;
        HashSet<int> seen = new(len);
        for(int i=0;i<len;i++){
            if(seen.Contains(nums[i])) return true;
            seen.Add(nums[i]);
        }
        return false;
    }
}