

namespace CardsManagement
{

    class prgram 
    {
     static void Main(string[] args)
    {

        string InputFromConsole = null;
        Console.WriteLine("Enter your card type");
        InputFromConsole= Console.ReadLine();

        ICreditCard creditCard = CardFactory.GetCreditCard(InputFromConsole);


        Console.WriteLine("your card type is: " + creditCard.GetCardType());
        Console.WriteLine("you card limit is: " + creditCard.GetCardLimit());
        Console.WriteLine("your card annual charge is:" + creditCard.GetAnnualCharge());

        
    }
}
}

