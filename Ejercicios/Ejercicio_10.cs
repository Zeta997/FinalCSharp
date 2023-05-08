using Ejercicio;
using static System.Console;

class Ejercicio_10{
   public void NumeroPositivoNegativoCero()
{

    int num;

    Write("Introduce un número entero: ");
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }

    if (num > 0)
        WriteLine($"{num} es un número positivo");
    else if (num < 0)
        WriteLine($"{num} es un número negativo");
    else
        WriteLine($"{num} es cero");

    ReadKey();
}
}