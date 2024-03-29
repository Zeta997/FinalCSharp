using Ejercicio;
using static System.Console;

class Ejercicio_13{
   public void Anagrama()
{
    string palabra1 = "roma";
    string palabra2 = "amor";

    char[] letras1 = palabra1.ToLower().ToCharArray();
    char[] letras2 = palabra2.ToLower().ToCharArray();

    Array.Sort(letras1);
    Array.Sort(letras2);

    bool sonAnagramas = letras1.SequenceEqual(letras2);

    if (sonAnagramas)
    {
        WriteLine($"{palabra1} y {palabra2} son anagramas.");
    }
    else
    {
        WriteLine($"{palabra1} y {palabra2} no son anagramas.");
    }
}
}