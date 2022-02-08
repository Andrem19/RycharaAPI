namespace RycharaAPI.RycharaLuckyBot.Indicators
{
    public class FibonacciCalcNet
    {
        public static void FibL(double low, double high)
        {
            Variables.line236 = high - ((high - low) * 0.236);
            Variables.line382 = high - ((high - low) * 0.382);
            Variables.line5 = high - ((high - low) * 0.5);
            Variables.line618 = high - ((high - low) * 0.618);
            Variables.line786 = high - ((high - low) * 0.786);
        }
        public static void FibS(double high, double low2)
        {
            Variables.line236S = low2 + ((high - low2) * 0.236);
            Variables.line382S = low2 + ((high - low2) * 0.382);
            Variables.line5S = low2 + ((high - low2) * 0.5);
            Variables.line618S = low2 + ((high - low2) * 0.618);
            Variables.line786S = low2 + ((high - low2) * 0.786);
        }
    }
}
