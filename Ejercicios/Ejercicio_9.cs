using Ejercicio;
using static System.Console;

class Ejercicio_9{
   public void SumaNumerosPares()
{
    List<int> numeros = new List<int>() ;
    int suma = 0;
    while(true){
     Write("Introduce un numero: ");
     string? valorInput = ReadLine();
     try{
     if(valorInput!=null) {
        int valorAEntero = Convert.ToInt32(valorInput);
        numeros.Add(valorAEntero);
        Write("¿Desea finalizar?(s/n): ");
        string? finalizar= ReadLine();
        if(finalizar!=null && finalizar.ToLower()=="s") break;
     }
     }catch(Exception){
        WriteLine("Valor erroneo.");
     }
    }
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