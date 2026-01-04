//Generic : basicamente nos ayuda a reutilizar codigo
using System.ComponentModel;
using System.Globalization;

MyList numbers = new MyList(10);
numbers.Add(5);
numbers.Add(3);
numbers.Add(2);

//ejemplo con Generic
MyListGeneric<int> numbersGeneric = new MyListGeneric<int>(10);
numbersGeneric.Add(3);
numbersGeneric.Add(5);
numbersGeneric.Add(4);
numbersGeneric.Add(7);

MyListGeneric<string> stringsGeneric = new MyListGeneric<string>(10);
stringsGeneric.Add("Mauro");
stringsGeneric.Add("Franco");
stringsGeneric.Add("Lucas");
stringsGeneric.Add("Sebastian");

MyListGeneric<People> people = new MyListGeneric<People>(10);
people.Add(new People() { Name = "Mauro", Country = "Argentina" });
people.Add(new People() { Name = "Franco", Country = "Argentina" });



Console.WriteLine(numbersGeneric.GetElement(0));
Console.WriteLine(numbersGeneric.GetElement(2));
Console.WriteLine(numbersGeneric.GetElement(4));//devuelve 0 por default, fuera de rango
Console.WriteLine(stringsGeneric.GetElement(0));
Console.WriteLine(stringsGeneric.GetElement(3));
Console.WriteLine(stringsGeneric.GetElement(4));//devuelve null por default, fuera de rango
Console.WriteLine(numbersGeneric.GetString());
Console.WriteLine(stringsGeneric.GetString());
Console.WriteLine(people.GetString());

public class MyList //clase para alamcenar n elementos y valida que no excedan un limite
{ 
    private int[] _elements;
    private int _index = 0;

    public MyList(int n)//constructor de mi lista
    {
        _elements = new int[n];
    }

    public void Add(int e)
    {
        if (_index < _elements.Length)
        {
            _elements[_index] = e;
            _index++;
        }
    }
}

public class MyListGeneric<T>
{
    private T[] _elements;
    private int _index = 0;

    public MyListGeneric(int n)
    {
        _elements = new T[n];
    }

    public void Add(T e)
    {
        if (_index < _elements.Length)
        {
            _elements[_index] = e;
            _index++;
        }
    }

    public T GetElement(int i)
    {
        if (i <= _index && i >= 0)
        {
            return _elements[i];
        }
        return default(T);//el valor por defecto de un objeto es el null
    }

    public string GetString()
    {
        int i = 0;
        string result = "";
        while (i < _index)
        {
            result += _elements[i].ToString() + "|";
            i++;
        }
        return result;
    }
}

public class People
{ 
    public string Name { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, Pais: {Country}";
    }
}