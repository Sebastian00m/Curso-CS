//INTERFACE :
//ES un contrato que debe complir una clase, es decir que si quiero implementar una interfaz debo cumplir con los metodos y propiedades que este exige

//Fundamentalmente sirven para categorizar las clases y obligarlas a cumplir con ciertos metodos y propiedades
//las interfaces se utilizan para "obligar a utilizar ciertos metodos y propiedades"
//ayuda mucho a la convencion de codigo para los programadores

Shark[] sharks = new Shark[]
{
    new Shark("tibu1", 45),
    new Shark("tibu2", 55),
    new Shark("tibu3", 65)
};

//como crear un array de Sirenas sin utilizar el tipo/objetos Siren, puedo hacerlo directamente de la interfaz
IFish[] fishs = new IFish[]
{
    new Siren(100),
    new Shark("Tiburoncin", 100)//tanto Siren como Shark cumplen con el contrato de IFish
};

ShowFish(sharks);
ShowAnimal(sharks);
ShowFish(fishs);//ya que Shark y Siren tienen implementado el metodo ShowSwim porque cumplen con la interface IFish



// Defino métodos que puedan implementar las interfaces
void ShowFish(IFish[] fishs)
{
    Console.WriteLine("-- Mostramos los peces de la interface IFish --");
    int i = 0;
    while (i < fishs.Length)
    {
        Console.WriteLine(fishs[i].Swim());
        i++;
    }
}
//defino un metodo en main para poder recorrer la interface IAnimal
void ShowAnimal(IAnimal[] animals)
{
    Console.WriteLine("-- Mostramos los animales de la interface IAnimal --");
    int i = 0;
    while (i < animals.Length)
    {
        Console.WriteLine(animals[i].Name);
        i++;
    }
}


public class Shark : IAnimal, IFish
{
    public string Name { get; set; }

    public int Velocidad { get; set; }

    public Shark(string name, int velocidad)
    {
        this.Name = name;
        this.Velocidad = velocidad;
    }
    public string Swim()
    {
        return $"{Name} nada  a {Velocidad} km/h";
    }
}

public class Siren : IFish
{
    public int Velocidad { get; set; }

    public Siren(int velocidad)
    {
        this.Velocidad = velocidad;
    }
    public string Swim()
    {
        return $"La sirena nada a {Velocidad} km/h";
    }
}
public interface IAnimal
{
    public string Name { get; set; }
    //si qeures utilizar con la interfaz IAnimal debes implementar esta propiedad en tu clase
}

public interface IFish
{
    public int Velocidad { get; set; }
    public string Swim();
    //si queres utilizar la interface IFish, debes implemtar la prop Velocidad y el metodo Swim
}