using Ejercicio;
using static System.Console;

class Ejercicio_3{
   public void AnyoBisiesto()
{
    Write("Ingrese un año: ");
    try{
    int anio = 0;
    if (int.TryParse(ReadLine(), out anio))

        if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
        {
            WriteLine(anio + " es un año bisiesto");
        }
        else
        {
            WriteLine(anio + " no es un año bisiesto");
        }
    }catch(Exception){
        WriteLine("Ha entrado un año incorrecto");
    }
}
}