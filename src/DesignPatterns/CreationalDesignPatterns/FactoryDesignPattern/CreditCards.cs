namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern;

internal class CreditCards
{
    internal enum CreditCardType
    {
        MoneyBack,
        Titanium,
        Platium
    }

    internal class MoneyBack : ICreditCard
    {
        public CreditCardType GetCardType() => CreditCardType.MoneyBack;

        public int GetCreditLimit() => 15_000;

        public int GetAnnualCharge() => 500;
    }

    internal class Titanium : ICreditCard
    {
        public CreditCardType GetCardType() => CreditCardType.Titanium;

        public int GetCreditLimit() => 25_000;

        public int GetAnnualCharge() => 1_500;
    }

    internal class Platium : ICreditCard
    {
        public CreditCardType GetCardType() => CreditCardType.Platium;

        public int GetCreditLimit() => 35_000;

        public int GetAnnualCharge() => 2_000;
    }
}
