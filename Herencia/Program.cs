
Doctor doctor = new Doctor("Juan", 40, "Traumatologia", 123);
Console.WriteLine("Este es un Doctor :");
Console.WriteLine(doctor.GetInfo());
Console.WriteLine(doctor.GetData());

Console.WriteLine("\n");
Dev dev = new Dev("Mauro", 25, "Trainee", "C#");
Console.WriteLine("Este es un desarrollador :");
Console.WriteLine(dev.GetInfo());
Console.WriteLine(dev.GetData());


class People
{
    //cuando los atributos son privados se indica que es privado
    private string _name;
    private int _age;

    public People(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string GetInfo()
    {
        return _name + " " + _age;
    }

}

//Herencia
//si quiero crear una clase y heredar las cualidades de otra se hace..
class Doctor : People
{
    private string _speciality;
    private int _matricula;
    public Doctor(string name, int age, string speciality, int matricula) : base(name, age)
    {
        _speciality = speciality;
        _matricula = matricula;
    }

    public string GetData()
    {
        return GetInfo() + ", " + " Nro Matricula : " + _matricula + ", " +" Especialidad : " + _speciality;
    }

}

class Dev : People 
{
    private string _language;
    private string _seniority;

    public Dev(string name, int age, string seniority, string language) : base(name, age)
    {
        _language = language;
        _seniority = seniority;
    }

    public string GetData()
    {
        return GetInfo() + " " + "Dev " + _seniority + " en " + _language;    
    }
}