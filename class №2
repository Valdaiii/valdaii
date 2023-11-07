using System;

public class Repository<T>
{
    private List<T> items = new List<T>();

    public delegate bool Criteria<T>(T item);

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> Find(Criteria<T> criteria)
    {
        List<T> result = new List<T>();
        foreach (T item in items)
        {
            if (criteria(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Repository<int> intRepository = new Repository<int>();
        intRepository.Add(1);
        intRepository.Add(2);
        intRepository.Add(3);
        intRepository.Add(4);
        intRepository.Add(5);

        Repository<string> stringRepository = new Repository<string>();
        stringRepository.Add("apple");
        stringRepository.Add("banana");
        stringRepository.Add("cherry");
        stringRepository.Add("date");
        stringRepository.Add("fig");

        Console.WriteLine("Цілі числа більше 3:");
        List<int> ints = intRepository.Find(x => x > 3);
        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nРядки, які містять 'a':");
        List<string> strings = stringRepository.Find(x => x.Contains("a"));
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
    }
}
