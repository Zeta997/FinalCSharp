using Ejercicio;
using static System.Console;

class Ejercicio_1{
    public void MenorMayor()
    {

    List<int> numeros= new List<int>();
    while(true){
    Write("Introduce valores: ");
    string? valorInput= ReadLine();
    try{
        int valorAEntero = Convert.ToInt32(valorInput);
        numeros.Add(valorAEntero);
        Write("¿Desea finalizar(s/n): ");
        string? finalizar= ReadLine();
        if(finalizar!=null){
            if(finalizar.ToLower()=="s"){
                break;
            }
        }
    }catch(Exception e){
        WriteLine(e);
    }
    }
    int maxValor= numeros.Max();
    int minValor= numeros.Min();
    WriteLine("El mayor número es: " + maxValor);
    WriteLine("El menor número es: " + minValor);
    ReadLine();
    
    }
}