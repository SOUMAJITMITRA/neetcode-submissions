public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> ret = new List<int>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int key = nums[i];
            if (map.ContainsKey(key))
            {
                map[key]++;
            }
            if (!map.ContainsKey(key))
            {
                map.Add(key, 1);
            }
        }
        // while(k>0){
        //     int keyWithMaxValue = map.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        //     ret.Add(keyWithMaxValue);
        //     map.Remove(keyWithMaxValue);
        //     k--;
        // }



        //  return ret.ToArray();
        return map
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();



        
    }
}
