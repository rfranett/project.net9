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
else if (letra == "b" || letra =="c" || letra == "d" || letra == "f" || letra == "g" || letra == "h" || letra == "j" || letra == "k" || letra == "l"
 || letra == "m" || letra == "n" || letra == "p" || letra == "q" || letra == "r" || letra == "s" || letra == "t" || letra == "v" || letra == "w"
  || letra == "x" || letra == "y" || letra == "z")
{
    Console.WriteLine("Consoantes");
}
else
{
    Console.WriteLine("Não é uma Vogal");
}