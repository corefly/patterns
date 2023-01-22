using DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodDesignPattern;

internal abstract class CreditCardFactory
{
    protected abstract ICreditCard MakeProduct();

    public ICreditCard CreateCreditCard()
    {
        return MakeProduct();
    }
}
