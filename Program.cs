﻿using project.net9.models ;

namespace SeuNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma Letra");
            string letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" 
            || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine("É uma Vogal");
            }
            else if (char.IsLetter(letra[0])) //Essa versão também simplificou a lógica para verificar se é uma vogal ou consoante
            // usando char.IsLetter. Além disso, ajustei a lógica para imprimir "É uma Consoante" quando é uma letra, mas não é uma vogal
            {
                Console.WriteLine("É uma Consoante");
            }
            else
            {
                Console.WriteLine("Não é uma Vogal");
            }
        }
    }
}

/*using project.net9.models ;

Console.WriteLine("Digite uma Letra");
string letra = Console.ReadLine();

if (letra == "a")
{
    Console.WriteLine(" É uma Vogal");
}
else if (letra == "e" || letra =="i" || letra == "o" || letra == "u" ||letra == "A" ||letra == "E" || letra =="I" || letra == "O" || letra == "U")
{
    Console.WriteLine(" É uma Vogal");
}
else if (letra == "b" || letra =="c" || letra == "d" || letra == "f" || letra == "g" || letra == "h" || letra == "j" || letra == "k" || letra == "l"
  || letra == "m" || letra == "n" || letra == "p" || letra == "q" || letra == "r" || letra == "s" || letra == "t" || letra == "v" || letra == "w"
  || letra == "x" || letra == "y" || letra == "z" ||letra == "B" || letra =="C" || letra == "D" || letra == "F" || letra == "G" || letra == "H" || letra == "J"
  || letra == "K" || letra == "L" || letra == "M" || letra == "N" || letra == "P" || letra == "Q" || letra == "R" || letra == "S" || letra == "T"
  || letra == "V" || letra == "W" || letra == "X" || letra == "Y" || letra == "Z")
{
    Console.WriteLine("É uma Consoantes");
}
else
{
    Console.WriteLine("Não é uma Vogal");
}*/