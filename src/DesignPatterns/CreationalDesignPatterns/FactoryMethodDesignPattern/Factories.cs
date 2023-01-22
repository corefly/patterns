using DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern;
using static DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.CreditCards;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodDesignPattern;

internal static class Factories
{
    public class MoneyBackCreditCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new MoneyBack();
    }
    public class PlatinumCreditCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new Platium();
    }
    public class TitaniumCreditCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new Titanium();
    }
}
