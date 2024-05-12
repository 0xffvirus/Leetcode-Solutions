public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int sell = 1;
        int max_profit = 0;
        while (sell < prices.Length) {
            int currentprofit = prices[sell] - prices[buy];
            if (prices[buy] < prices[sell]) {
                max_profit = Math.Max(max_profit, currentprofit);
            } else {
                buy = sell;
            }
            sell++;
        }
        return max_profit;

    }
}
