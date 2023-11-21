using System;

class Converter
{
    private double usdNew;
    private double eurNew;
    private double plnNew;

    public Converter(double usd, double eur, double pln)
    {
        usdNew = usd;
        eurNew = eur;
        plnNew = pln;
    }
    public double USDtoUAH(double usd)
    {
        return usd * usdNew;
    }
    public double EURtoUAH(double eur)
    {
        return eur * eurNew;
    }
    public double PLNtoUAH(double pln)
    {
        return pln * plnNew;
    }
    public double UAHtoUSD(double uah)
    {
        return uah / usdNew;
    }
    public double UAHtoEUR(double uah)
    {
        return uah / eurNew;
    }
    public double UAHtoPLN(double uah)
    {
        return uah / plnNew;
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(37.0, 40.4, 0.11);
        double uahNew = 1000.0;
        double usdNew = converter.UAHtoUSD(uahNew);
        Console.WriteLine("{0} UAH = {1} USD", uahNew, usdNew);

        double uahNew2 = 1000.0;
        double eurNew = converter.UAHtoEUR(uahNew);
        Console.WriteLine("{0} UAH = {1} EUR", uahNew, eurNew);

        double uahNew3 = 1000.0;
        double plnNew = converter.UAHtoPLN(uahNew);
        Console.WriteLine("{0} UAH = {1} PLN", uahNew, plnNew);

        Console.ReadLine();
    }
}
