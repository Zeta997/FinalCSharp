using Ejercicio;
using static System.Console;

class Ejercicio_4{
    public void palindromo()
{
    Write("Ingrese una palabra : ");
    string? texto = ReadLine();
    if (texto == null)
    {
        Write("Texto invalido");
        return;
    }
    texto = texto.ToLower().Replace(" ", "");
    string letraReves="";
    foreach(var letra in texto){
        letraReves =letra +letraReves;
    }

    if(texto==letraReves)WriteLine("La cadena es un palíndromo");
    else WriteLine("La cadena no es un palíndromo");


}
}