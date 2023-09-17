using System;
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;
    public string Index
    {
        get { return index; }
        set { index = value; }
    }
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string Street
    {
        get { return street; }
        set { street = value; }
    }
    public string House
    {
        get { return house; }
        set { house = value; }
    }
    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

}
class Program
{
    static void Main()
    {
        Address address = new Address();

        address.Index = "40576";
        address.Country = "Ukraine";
        address.City = "Lviv";
        address.Street = "Indecency";
        address.House = "10а";
        address.Apartment = "503";

        Console.WriteLine("Index" + address.Index);
        Console.WriteLine("Country" + address.Country);
        Console.WriteLine("City" + address.City);
        Console.WriteLine("Street" + address.Street);
        Console.WriteLine("Hous" + address.House);
        Console.WriteLine("Apartment" + address.Apartment);

        Console.ReadLine();
    }
}



