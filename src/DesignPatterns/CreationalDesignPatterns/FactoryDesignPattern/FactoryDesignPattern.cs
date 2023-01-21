namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern;

public class FactoryDesignPattern : IDesignPattern
{
    public void RunPatternExample()
    {
        var card = CreditCardFactory.GetCreditCard(CreditCards.CreditCardType.Platium);

        if (card != null)
        {
            Console.WriteLine("CardType : " + card.GetCardType());
            Console.WriteLine("CreditLimit : " + card.GetCreditLimit());
            Console.WriteLine("AnnualCharge :" + card.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }

        Console.ReadLine();
    }
}
