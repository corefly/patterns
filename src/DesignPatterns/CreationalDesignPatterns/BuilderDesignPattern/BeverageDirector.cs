namespace DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern;

internal class BeverageDirector
{
    public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
    {
        beverageBuilder.CreateBeverage();
        beverageBuilder.SetBeverageType();
        beverageBuilder.SetWater();
        beverageBuilder.SetMilk();
        beverageBuilder.SetSugar();
        beverageBuilder.SetPowderQuantity();
            
        return beverageBuilder.GetBeverage();
    }
}
