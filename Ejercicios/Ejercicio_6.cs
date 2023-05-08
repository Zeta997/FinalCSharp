using Ejercicio;
using static System.Console;

class Ejercicio_6{
   public void factorial()
{
    int num = 0, factorial = 1;

    Write("Introduce un número entero positivo: ");
    if (int.TryParse(ReadLine(), out num))
    {

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        WriteLine($"El factorial de {num}! es {factorial}");
    }
    else
        WriteLine("Número inválido");

    ReadKey();
}
}