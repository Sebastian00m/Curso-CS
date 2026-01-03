//static : nos permite que algo (metodo, propiedad, atributo) pertenezca unicamente ala clase a y no al objeto

People people = new People()
{
    Name = "Mauro",
    Age = 25
};

People people1 = new People()
{
    Name = "Franco",
    Age = 26
};
Console.WriteLine(People.Count);//imprimo un atributo static
Console.WriteLine(People.GetCount());//imprimo un metodo static

public class People
{
    public static int Count = 0;
    public string Name { get; set; }
    public int Age { get; set; }

    public People()
    {
        Count++;
    }

    public static string GetCount()
    {
        return $"La Clase People a sido utilizada, {Count} veces.";
    }
}
