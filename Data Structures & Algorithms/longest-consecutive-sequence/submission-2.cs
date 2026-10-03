public class Solution {
    public int LongestConsecutive(int[] nums) {
    //    if(nums.Length > 0){
    //     int counter = 1;
    //     Array.Sort(nums);
    //     int minValue = nums[0];

    //     List<int> counterList = new List<int>();
    //     counterList.Add(counter);

    //     for ( int i = 1 ; i< nums.Length ; i ++){
    //         if (nums[i] == minValue + 1){
    //             minValue++;
    //             counter++;
    //             counterList.Add(counter);
    //         }
    //         else if(nums[i] == minValue){
    //             continue;
    //         }
    //         else {
    //             minValue = nums[i];
    //             counter = 1;
    //             counterList.Add(counter);
    //         }
    //     }
    //     return counterList.Max();
    //    }
    //    else {
    //     return 0;
    //    }
    if (nums.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in set)
        {
            // Only start counting if it's the beginning of a sequence
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longest = Math.Max(longest, currentStreak);
            }
        }

        return longest;
    }
}
