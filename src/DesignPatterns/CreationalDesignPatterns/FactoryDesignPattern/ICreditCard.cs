namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern;

internal interface ICreditCard
{
    CreditCards.CreditCardType GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}
