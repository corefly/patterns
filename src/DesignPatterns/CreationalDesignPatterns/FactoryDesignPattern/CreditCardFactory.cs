namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern;

internal class CreditCardFactory
{
    public static ICreditCard? GetCreditCard(CreditCards.CreditCardType type)
    {
        return type switch
        {
            CreditCards.CreditCardType.MoneyBack => new CreditCards.MoneyBack(),
            CreditCards.CreditCardType.Titanium => new CreditCards.Titanium(),
            CreditCards.CreditCardType.Platium => new CreditCards.Platium(),
            _ => null
        };
    }
}
