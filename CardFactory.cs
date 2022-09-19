namespace CardsManagement
{
    public class CardFactory
    {
        
        public static ICreditCard GetCreditCard(string Type)
        {
            ICreditCard creditCard = null;
            if(Type == "VisaCard")
            {
                creditCard = new VisaCard();
            }
            else if (Type == "MasterCard")
            {
                creditCard = new MasterCard();
            }
            else if (Type == "RuPay")
            {
                creditCard = new RuPay();
            }
        
            return creditCard;
        }

    }
}