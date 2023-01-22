namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodDesignPattern;

internal class FactoryMethodDesignPattern : IDesignPattern
{
    public void RunPatternExample()
    {
        var creditCard = new Factories.PlatinumCreditCardFactory().CreateCreditCard();

        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }

        Console.WriteLine("--------------");

        creditCard = new Factories.MoneyBackCreditCardFactory().CreateCreditCard();

        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }

        Console.ReadLine();
    }
}
