public class Solution {
    public int LengthOfLongestSubstring(string s) {

        // if (s.Length == 0){
        //     return 0;
        // }
        // List<int> lengths = new List<int>();
        // List<char> sub = new List<char>();
        // foreach (var c in s)
        // {
            
        //     if (sub.Contains(c)){
        //         lengths.Add(sub.Count);
        //         sub.RemoveRange(0, sub.IndexOf(c) + 1);
        //         sub.Add(c);
        //         lengths.Add(sub.Count);
        //     }
        //     else{
        //         sub.Add(c);
        //         lengths.Add(sub.Count);
        //     }

        // }
        // return lengths.Max();

        if (string.IsNullOrEmpty(s)) return 0;

        Dictionary<char, int> map = new Dictionary<char, int>();
        int maxLen = 0, start = 0;

        for (int i = 0; i < s.Length; i++) {
            if (map.ContainsKey(s[i]) && map[s[i]] >= start) {
                start = map[s[i]] + 1;  // move start just past the duplicate
            }
            map[s[i]] = i;  // update latest index of character
            maxLen = Math.Max(maxLen, i - start + 1);
        }

        return maxLen;
    }
}
