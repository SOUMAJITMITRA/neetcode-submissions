public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0;

        for(int i = 0 ; i < prices.Length ; i ++){
            int maxprofitemp = prices[i] - minPrice;
            if (maxprofitemp > maxProfit){
                maxProfit = maxprofitemp;
            }
            if (prices [i] <= minPrice){
                minPrice =  prices[i];
            }
            
            
        }
        return maxProfit;
    }
}
