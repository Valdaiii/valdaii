using System;

public class Calculator<T>
{
    public delegate T БінарнаОперація(T a, T b);

    public БінарнаОперація Додавання { get; set; }
    public БінарнаОперація Віднімання { get; set; }
    public БінарнаОперація Множення { get; set; }
    public БінарнаОперація Ділення { get; set; }

    public Calculator()
    {
        Додавання = (a, b) => (dynamic)a + (dynamic)b;
        Віднімання = (a, b) => (dynamic)a - (dynamic)b;
        Множення = (a, b) => (dynamic)a * (dynamic)b;
        Ділення = (a, b) =>
        {
            if (b.Equals((dynamic)0))
            {
                throw new DivideByZeroException("Ділення на нуль не допускається.");
            }
            return (dynamic)a / (dynamic)b;
        };
    }

    public T ВиконатиОперацію(T операнд1, T операнд2, БінарнаОперація операція)
    {
        if (операція == null)
        {
            throw new ArgumentNullException("Операція не може бути null.");
        }
        return операція(операнд1, операнд2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator<int> ціліCalculator = new Calculator<int>();
        Console.WriteLine("Калькулятор для цілих чисел:");
        Console.WriteLine($"Додавання: {ціліCalculator.ВиконатиОперацію(5, 3, ціліCalculator.Додавання)}");
        Console.WriteLine($"Віднімання: {ціліCalculator.ВиконатиОперацію(5, 3, ціліCalculator.Віднімання)}");
        Console.WriteLine($"Множення: {ціліCalculator.ВиконатиОперацію(5, 3, ціліCalculator.Множення)}");
        Console.WriteLine($"Ділення: {ціліCalculator.ВиконатиОперацію(5, 3, ціліCalculator.Ділення)}");

        Calculator<double> дробовіCalculator = new Calculator<double>();
        Console.WriteLine("\nКалькулятор для чисел з рухомою комою:");
        Console.WriteLine($"Додавання: {дробовіCalculator.ВиконатиОперацію(5.5, 3.2, дробовіCalculator.Додавання)}");
        Console.WriteLine($"Віднімання: {дробовіCalculator.ВиконатиОперацію(5.5, 3.2, дробовіCalculator.Віднімання)}");
        Console.WriteLine($"Множення: {дробовіCalculator.ВиконатиОперацію(5.5, 3.2, дробовіCalculator.Множення)}");
        Console.WriteLine($"Ділення: {дробовіCalculator.ВиконатиОперацію(5.5, 3.2, дробовіCalculator.Ділення)}");
    }
}
