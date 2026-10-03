public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // List<int> ret = new List<int>();
        // for(int i = 0 ; i < nums.Length ; i++){
        //     for(int j = 0 ; j < nums.Length ; j++){
        //         if ( i != j){
        //             if(nums[i] + nums[j] == target){
        //                 ret.Add(i);
        //                 ret.Add(j);
        //                 break;
        //             }
        //         }
        //     }
        //     if (ret.Count > 0){
        //         break;
        //     }
        // }
        // int[] arr = ret.ToArray();
        // Array.Sort(arr);
        // return arr;


        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            // Store the current number with its index
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }
        // If no solution found, return empty array
        return new int[0];
    }
}
