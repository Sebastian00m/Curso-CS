internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 2;

        int c = a + b;
        int d = a + b;

        Show();
        Suma(a, b);
        Console.Write(Mul(a, b));

        int num = Mul(a, b);


    }

    static int Mul(int a, int b)
    {
        return a * b;
    }

    static void Suma(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static void Show()
    {
        Console.WriteLine("Hola, Mundo");
    }
}