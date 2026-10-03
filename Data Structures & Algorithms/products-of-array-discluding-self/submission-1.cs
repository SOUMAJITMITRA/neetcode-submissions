public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // List<int> prefix = new List<int>();
        // List<int> postfix =  new List<int>();

        // prefix.Add(1);
        

        // int prod1 = 1 ;
        // int prod2 = 1 ;

        // for (int i = 1 ; i < nums.Length ; i ++ ){
        //     prod1 = prod1 * nums[i-1];
        //     prefix.Add(prod1);
        // }


        // for (int i = nums.Length - 2 ; i >= 0 ; i -- ){
        //     prod2 = prod2 * nums[i+1];
        //     postfix.Insert(0, prod2);
        // }

        // postfix.Add(1);

        // List<int> final = new List<int>();
        // for (int i = 0 ; i < nums.Length ; i ++ ){
        //     final.Add(prefix[i]*postfix[i]);
        // }

        // return final.ToArray();

        int n = nums.Length;
        int[] result = new int[n];

        // Step 1: Build prefix products
        result[0] = 1;
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        // Step 2: Multiply with postfix products
        int postfix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }
}
