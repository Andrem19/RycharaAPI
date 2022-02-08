namespace RycharaAPI
{
    public enum Exchanges
    {
        BINANCE1,
        BINANCE2,
        BYBIT1,
        BYBIT2
    }
    public static class Variables
    {
        //General Variables
        public static Exchanges Exchange { get; set; } = Exchanges.BYBIT1;
        public static string sym { get; set; } = "DOT";
        public static string symbol { get; set; } = $"{sym}USDT";
        public static string limitCandels { get; set; } = "200";
        public static string limitCandelsFib { get; set; } = "500";
        public static string interval { get; set; } = "5";
        public static string intervalFib { get; set; } = "5";
        public static string intervalLetter { get; set; } = "m";
        public static string intervalFibLetter { get; set; } = "m";
        public static double amount { get; set; } = 0.5;
        public static double baseAmount { get; set; } = 0.5;
    }
}
