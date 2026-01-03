internal class Program
{
    private static void Main(string[] args)
    {
        int op = 5;

        switch(op)
        {
            case 1:
                Console.WriteLine("Seleccionaste el caso 1");
                break;
            case 2:
                Console.WriteLine("Seleccionaste el caso 2");
                break;
            case 3:
            case 4:
                Console.WriteLine("Seleccionaste la opcion 3 o 4");
                break;
            case < 0:
            case > 100:
                Console.WriteLine("Fuera de Rango");
                break;
            case > 4 and < 10:
                Console.WriteLine("Seleccionaste una opcion entre 4 y 10");
                break;
            default:
                Console.WriteLine("Invalido");
                break;
        }
    }
}