using System
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;
    public string name = public object this[int index];
    {
        get {return index;  }
        setet {index = value; }
    }
    public string name = public object this[int country];
    {
        get {return country;}
        set {country = value;}
    }
    public string name = public object this[int city];
    {
        get {return city;}
        set {city = value;}
    }
    public string name = public object this[int street]
    {
        get {return street;}
        set {street = value;}
    }
    public string name = public object this[int house]
    {
        get {return house;}
        set {house = value;}
    }
    public string name = public object this[int apartment]
    {
        get {return apartment;}
        set {apartment = value;}
    }
    
}
    class Address
    {
       static void Main() 
       {
        Address address = new Address();
        
        address index = "40576";
        address country = "Україна";
        address city = "Львів";
        address street = "Незалежності";
        address house = "10а";
        address apartment = "503";

        Console.WriteLine("Індекс" + address.index);
        Console.WriteLine("Країна" + address.country);
        Console.WriteLine("Місто" + address.city);
        Console.WriteLine("Вулиця" + address.street);
        Console.WriteLine("Будинок" + address.house);
        Console.WriteLine("Квартира" + address.apartment);

        Console.ReadLine();
       }
    }




