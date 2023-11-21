using System;

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now;
    }
    public void DisplayUserInfo()
    {
        Console.WriteLine("login" + login);
        Console.WriteLine("firstName" + firstName);
        Console.WriteLine("lastName" + lastName);
        Console.WriteLine("age" + age);
        Console.WriteLine("DateTime registrationDate" + registrationDate.ToString("yyyy-MM-dd HH:mm:ss"));
    }
    class Program
    {
        static void Main()
        {
            User user = new User("john_doe", "John", "Doe", 30);

            user.DisplayUserInfo();

            Console.ReadLine();
        }
    }
}
