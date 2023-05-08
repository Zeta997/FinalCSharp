using Ejercicio;
using static System.Console;

class Ejercicio_2{
    public void ParImpar()
{
    int numero = 0;
    Write("Ingrese un número entero: ");
    try{
        if (int.TryParse(ReadLine(), out numero))
            if (numero % 2 == 0)
            {
                WriteLine("El número es par");
            }
            else
            {
                WriteLine("El número es impar");
            }
    }catch(Exception)
    {
        WriteLine("Ha entrado un número erroneo");
    }
}
}