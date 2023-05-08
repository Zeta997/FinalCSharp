using Ejercicio;
using static System.Console;

class Ejercicio_14{
   public void EliminarDuplicados()
{
    List<int> numeros = new List<int>();
    while(true){
        Write("Introduce un valor: ");
        string? valorInput= ReadLine();
        if(valorInput!=null){
            int valorAEntero= Convert.ToInt32(valorInput);
            numeros.Add(valorAEntero);
        }
        Write("¿Desea finalizar?(s/n): ");
            string? finalizar = ReadLine();
            if(finalizar!=null && finalizar.ToLower()=="s") break;
    }
    List<int> numerosSinDuplicados = new List<int>();

    foreach (int numero in numeros)
    {
        if (!numerosSinDuplicados.Contains(numero))
        {
            numerosSinDuplicados.Add(numero);
        }
    }

    WriteLine("Números originales: " + string.Join(", ", numeros));
    WriteLine("Números sin duplicar: " + string.Join(", ", numerosSinDuplicados));

}
}