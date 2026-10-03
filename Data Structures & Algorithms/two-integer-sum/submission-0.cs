public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> ret = new List<int>();
        for(int i = 0 ; i < nums.Length ; i++){
            for(int j = 0 ; j < nums.Length ; j++){
                if ( i != j){
                    if(nums[i] + nums[j] == target){
                        ret.Add(i);
                        ret.Add(j);
                        break;
                    }
                }
            }
            if (ret.Count > 0){
                break;
            }
        }
        int[] arr = ret.ToArray();
        Array.Sort(arr);
        return arr;
    }
}
