namespace CardsManagement
{
    public class VisaCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 17;
        }

        public int GetCardLimit()
        {
            return 1900;
        }

        public string GetCardType()
        {
            return "VisaCard";
        }
    }
}