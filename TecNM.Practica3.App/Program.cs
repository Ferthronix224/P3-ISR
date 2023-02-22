using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.App;

public static class Program
{
    public static void Main(string[] args)
    {
        float salary = 0;

        System.Console.Write("Please enter your salary -> ");
        Single.TryParse(System.Console.ReadLine(), out salary);

        var person = new Person { Salary = salary };
        var service = new IsrService();
        var manager = new IsrManager(service);

        ISR isr = manager.getSalary(person);

        System.Console.WriteLine($"The result is {isr.isr}");
    }
}
