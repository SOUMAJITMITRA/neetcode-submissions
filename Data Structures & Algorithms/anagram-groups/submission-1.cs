public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // List<List<string>> list = new List<List<string>>();
        // List<int> completedIndex = new List<int>();
        // for(int i = 0 ; i < strs.Length ; i++)
        // {
        //     if (completedIndex.Contains(i)){
        //         continue;
        //     }
        //     List<string> sublist = new List<string>();
        //     string str = strs[i];
        //     sublist.Add(str);
        //     completedIndex.Add(i);
        //     char[] charArray1 = str.ToCharArray();
        //     Array.Sort(charArray1);
        //     string matchingString1 = new string(charArray1);
        //     for(int j = i + 1 ; j < strs.Length ; j++){
        //         string str2 = strs[j];
        //         char[] charArray2 = str2.ToCharArray();
        //         Array.Sort(charArray2);
        //         string matchingString2 = new string(charArray2);
        //         if (matchingString1 == matchingString2){
        //             completedIndex.Add(j);
        //             sublist.Add(str2);
        //         }
        //     }
        //     list.Add(sublist);
        // }
        // return list;

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            // Sort the characters in the string to form the key
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            // Add the string to the correct group
            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }

        // Convert dictionary values to the required output format
        return new List<List<string>>(map.Values);
    }
}
