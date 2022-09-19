namespace CardsManagement
{
    public class RuPay : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 13;
        }

        public int GetCardLimit()
        {
            return 1490;
        }

        public string GetCardType()
        {
            return "RuPay";
        }
    }
}