namespace CardsManagement
{
    public class MasterCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 15;
        }

        public int GetCardLimit()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "MasterCard";
        }
    }
}