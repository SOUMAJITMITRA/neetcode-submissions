public class Solution {
    public bool IsPalindrome(string s) {
        // s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        // int halfLength = s.Length/2;
        // for(int i = 0 ; i < halfLength ; i ++){
        //     if(s[i] != s[s.Length - 1 - i]){
        //         return false;
        //     }
        // }
        // return true;

          s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLowerInvariant();

        int left = 0, right = s.Length - 1;
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
