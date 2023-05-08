using Ejercicio;
using static System.Console;

class Ejercicio_11{
   public void MediaLista()
{
    
    List<int> numeros= new List<int>();
    while(true){
        Write("Introduce un valor: ");
        string? valorInput= ReadLine();
        try{
            if(valorInput!=null){
                int valorAEntero = Convert.ToInt32(valorInput);
                numeros.Add(valorAEntero);
            }
            Write("¿Desea finalizar?(s/n): ");
            string? finalizar = ReadLine();
            if(finalizar!=null && finalizar.ToLower()=="s") break;
        }catch(Exception){
            WriteLine("Valor erroneo.");
        }
    }
    double media = numeros.Average();
    WriteLine("La media es: " + media);
}
}