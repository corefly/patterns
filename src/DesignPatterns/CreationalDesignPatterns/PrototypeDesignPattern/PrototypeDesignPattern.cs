namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern;

internal class PrototypeDesignPattern : IDesignPattern
{
    public void RunPatternExample()
    {
        var emp1 = new Employee();
        emp1.Name = "Anurag";
        emp1.Department = "IT";

        var emp2 = emp1.GetClone();
        emp2.Name = "Pranaya";

        Console.WriteLine("Emplpyee 1: ");
        Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
        Console.WriteLine("Emplpyee 2: ");
        Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);

        Console.Read();
    }

    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Employee GetClone()
        {
            return (Employee)Clone();
        }
    }
}
