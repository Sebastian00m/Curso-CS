using System;

Sale mySale = new Sale(-100, DateTime.Now);
Console.WriteLine(mySale.Total);
mySale.Total = -12323;
Console.WriteLine(mySale.Total);
//mySale.Date = DateTime.Now;

class Sale
{
    int total;
    DateTime date;

    //las propiedades nos ayudan a "cuidar " ciertos valores que no deben ser modificados ni accedidos

    //utilizamos el modificador de acceso  PUBLIC
    public string Date
    {
        get
        {
            return date.ToString();
        }

    }

    public int Total
    {
        get
        {
            return total;
        }
        set
        {

            if (value < 0)
                value = 0;
            total = value;
        }
    }

    public Sale(int total, DateTime date)
    {
        this.total = total < 0 ? 0 : total;
        this.date = date;
    }
}