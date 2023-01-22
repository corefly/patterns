namespace DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern;

internal class BuilderDesignPattern : IDesignPattern
{
    public void RunPatternExample()
    {
        Beverage beverage;
        var beverageDirector = new BeverageDirector();

        var tea = new TeaBuilder();
        beverage = beverageDirector.MakeBeverage(tea);
        Console.WriteLine(beverage.ShowBeverage());

        var coffee = new CoffeeBuilder();
        beverage = beverageDirector.MakeBeverage(coffee);
        Console.WriteLine(beverage.ShowBeverage());

        Console.ReadKey();
    }
}
