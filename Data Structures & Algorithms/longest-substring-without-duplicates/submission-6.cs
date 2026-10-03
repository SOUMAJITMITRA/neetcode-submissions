public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if (s.Length == 0){
            return 0;
        }
        List<int> lengths = new List<int>();
        List<char> sub = new List<char>();
        foreach (var c in s)
        {
            
            if (sub.Contains(c)){
                lengths.Add(sub.Count);
                sub.RemoveRange(0, sub.IndexOf(c) + 1);
                sub.Add(c);
                lengths.Add(sub.Count);
            }
            else{
                sub.Add(c);
                lengths.Add(sub.Count);
            }

        }
        return lengths.Max();
    }
}
