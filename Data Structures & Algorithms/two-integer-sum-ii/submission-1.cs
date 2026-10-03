public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Dictionary<int,int> map = new Dictionary<int,int>();

        // for (int i = 0 ; i < numbers.Length ; i ++ ){
        //     int complement = target - numbers[i];

        //     if (map.Keys.Contains(complement)){
        //         return new int[] {map[complement] + 1 , i + 1};
        //     }

        //     if(!map.Keys.Contains(numbers[i])){
        //         map.Add(numbers[i], i);
        //     }
        // }
        // return [];

        int left = 0;
    int right = numbers.Length - 1;

    while (left < right)
    {
        int sum = numbers[left] + numbers[right];

        if (sum == target)
        {
            // Return 1-based indices as per problem statement
            return new int[] { left + 1, right + 1 };
        }
        else if (sum < target)
        {
            left++; // Need a larger sum
        }
        else
        {
            right--; // Need a smaller sum
        }
    }

    return new int[0]; // No solution found
        
    }
}
