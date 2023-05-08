using Ejercicio;
using static System.Console;

class Ejercicio_7{

   public void NumeroPrimo()
{
    int num = 0, i;
    bool esPrimo = true;

    Write("Introduce un número entero positivo: ");
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }

    for (i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            esPrimo = false;
            break;
        }
    }

    if (esPrimo)
        WriteLine($"{num} es un número primo");
    else
        WriteLine($"{num} no es un número primo");
}
}