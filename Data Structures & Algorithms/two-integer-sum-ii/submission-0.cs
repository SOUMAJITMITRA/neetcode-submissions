public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        for (int i = 0 ; i < numbers.Length ; i ++ ){
            int complement = target - numbers[i];

            if (map.Keys.Contains(complement)){
                return new int[] {map[complement] + 1 , i + 1};
            }

            if(!map.Keys.Contains(numbers[i])){
                map.Add(numbers[i], i);
            }
        }
        return [];
        
    }
}
