using StockOnliner;
Console.WriteLine("Bank of America stock price:");

StockExchageMonitor stockExchageMonitor = new StockExchageMonitor();
stockExchageMonitor.PriceChangeHandler = ShowPrice;
stockExchageMonitor.Start();

static void ShowPrice(int price)
{
    Console.WriteLine($"New price is: {price}");
}