namespace CardsManagement
{
    public interface ICreditCard
    {

        string GetCardType();
        int GetCardLimit();
        int GetAnnualCharge();
        
    }
}