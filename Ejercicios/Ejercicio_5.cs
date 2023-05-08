using Ejercicio;
using static System.Console;

class Ejercicio_5{
    public void ordenarLista()
{
    List<string> nombres= new List<string>();
    while(true){
        Write("Ingresa un nombre: ");
        string? valorInput= ReadLine();
        if (valorInput!=null) nombres.Add(valorInput);
        Write("¿Desea finalizar?(s/n): ");
        string? finalizar = ReadLine();
        if(finalizar=="s" && finalizar!=null) break;
    }
    nombres.Sort();

    WriteLine("Lista ordenada alfabéticamente:");

    foreach (string nombre in nombres)
    {
        Write($"{nombre}, ");
    }
}
}