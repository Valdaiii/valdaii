using System;

class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;;
    }
    public void SetPositionAndExperience(string position, int experience)
    {
        this.position = position;
        this.experience = experience;
    }

    public double CalculateSalary()
    {
        double Salary = 0.0;

        switch (position)
        {
            case "Manager":
                Salary = 25000.0;
                break;
            case "Developer":
                Salary = 55000.0;
                break;
            case "System administrator":
                Salary = 100000.0;
                break;

          
        }
        double bonus = experience * 2500.0;

        double salary = Salary + bonus;

        return salary;
    }
    public double CalculateTax()
    {
        double Salary = CalculateSalary();
        double taxNew = 0.20;
        double tax = Salary * taxNew;
        return tax;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("lastName" + lastName);
        Console.WriteLine("firstName" +  firstName);
        Console.WriteLine("position" + position);
        Console.WriteLine("Salary" + CalculateSalary());
        Console.WriteLine("Tax" +  CalculateTax());

    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Zhuravel", "Vlad");

        employee.SetPositionAndExperience("System administrator", 5);

        employee.DisplayInfo();

        Console.ReadLine();
    }
}
