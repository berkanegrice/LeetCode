namespace LeetCode;

public static class MaxProfit
{
    public static int CalculateMaxProfit(int[] prices) 
    {
        var window = Enumerable.Range(1, prices.Length/2).ToArray();
        
        var highestProfit = 0;
        foreach (var t in window)
        {
            var arrayIndex = 0;
            var profit = 0;
            while(arrayIndex + t < prices.Length)
            {                
                if(prices[arrayIndex + t] > prices[arrayIndex])
                {
                    profit = profit + prices[arrayIndex + t] - prices[arrayIndex];
                }
                arrayIndex += t;
            }
            if(highestProfit < profit)
            {
                highestProfit = profit;
            }
        }
        return highestProfit;
    }
}