using Ejercicio;
using static System.Console;

class Ejercicio_5{
    public void ordenarLista()
{
    string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

    Array.Sort(nombres);

    WriteLine("Lista ordenada alfabéticamente:");

    foreach (string nombre in nombres)
    {
        WriteLine(nombre);
    }
}
}