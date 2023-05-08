using Ejercicio;
using static System.Console;

class Ejercicio_9{
   public void SumaNumerosPares()
{
    List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int suma = 0;

    foreach (int num in numeros)
    {
        if (num % 2 == 0){
            Write($"{num}, ");
            suma += num;
        }
    }

    WriteLine($"La suma de los números pares es {suma}");

    ReadKey();
}

}