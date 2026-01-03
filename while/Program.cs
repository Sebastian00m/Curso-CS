// See https://aka.ms/new-console-template for more information
int i = 0;

while(i < 10)
{
    Console.WriteLine("Iteracion de i "+ i);
    i ++;
}

int j = 0;
Console.WriteLine("Iteracion interrumpida con if ");
while (j < 100)
{
    //si quiero interrumpir el ciclo antes de que termine con una condicion
    if (j > 10)
        break;

    Console.WriteLine("Iteracion de j " + j);
    j++;
}

string[] amigos = new string[6]{
        "Mauro",
        "Franco",
         "Laura",
         "Luis",
         "Camila",
         "Magali"
    };

int index = 0;
Console.WriteLine("Iteracion de Array de amigos\n");
while(index < amigos.Length)
{
    Console.WriteLine(amigos[index]);
    index++;
}