public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        List<int> ans = nums.ToList();
        foreach ( int i in nums){
            ans.Add(i);
        }
        return ans.ToArray();
        // int[] ans  = nums.Concat(nums).ToArray();
        // return ans;
    }
}