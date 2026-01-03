
using System.Numerics;

Sale sale1 = new Sale(100,DateTime.Now);// UTILIZO LA CLASE dATEtIME CON EL METODO ESTATICO NOW
Console.WriteLine(sale1.GetInfo());
sale1.Show();



class Sale
{
    //"public" indica que puedo utilizar este objeto por fuera de la clase 
    int total;
    DateTime date;

    //defino el constructor para mi objeto, y que reciba los dos valores anteriores
    //el constructor se llama igual al clase
    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }

    //METODO QUE ME INFORMACION SOBRE LOS ATRIBUTOS ENVIADOS
    public string GetInfo()
    {
        return total + " " + date.ToLongDateString();
    }


    public void Show()
    {
        Console.WriteLine("Hola soy una venta");
    }
}
