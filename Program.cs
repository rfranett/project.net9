using project.net9.models ;

Console.WriteLine("Digite uma Letra");
string letra = Console.ReadLine();

if (letra == "a")
{
    Console.WriteLine("Vogal");
}
else if (letra == "e" || letra =="i" || letra == "o" || letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma Vogal");
}