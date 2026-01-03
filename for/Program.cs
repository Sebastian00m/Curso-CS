string[] amigos = new string[7]{
        "Mauro",
        "Franco",
         "Laura",
         "Luis",
         "Camila",
         "Magali",
          "Lucas"
    };

bool run = true;
for(int I = 0; I < amigos.Length && run; I++)
{
    Console.WriteLine(amigos[I]);
}
