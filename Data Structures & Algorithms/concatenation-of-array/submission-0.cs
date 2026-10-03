public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length =  nums.Length;
        List<int> ans = nums.ToList();
        foreach ( int i in nums){
            ans.Add(i);
        }
        return ans.ToArray();
    }
}