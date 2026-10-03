public class Solution {
    public bool hasDuplicate(int[] nums) {
        foreach (int num in nums ){
            int index = Array.IndexOf(nums, num);
            List<int> list = new List<int>(nums);
            list.RemoveAt(index);
            int[] tempNums = list.ToArray();
            if(tempNums.Contains(num)){
                return true;
            }
        }
        return false;
    }
}