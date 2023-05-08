using  System;
using static System.Console;
using static System.Math;


namespace Ejercicio{

    class Program{
         static void Main(){
            WriteLine("----------Menu----------");
            WriteLine("1.-Ejercicio 1");
            WriteLine("2.-Ejercicio 2");
            WriteLine("3.-Ejercicio 3");
            WriteLine("4.-Ejercicio 4");
            WriteLine("5.-Ejercicio 5");
            WriteLine("6.-Ejercicio 6");
            WriteLine("7.-Ejercicio 7");
            WriteLine("8.-Ejercicio 8");
            WriteLine("9.-Ejercicio 9");
            WriteLine("10.-Ejercicio 10");
            WriteLine("11.-Ejercicio 11");
            WriteLine("12.-Ejercicio 12");
            WriteLine("13.-Ejercicio 13");
            WriteLine("14.-Ejercicio 14");
            WriteLine("15.-Ejercicio 15");
            Write("Elije un ejercicio a ejecutar: ");
            string? valorInput= ReadLine();
            var elegir= new Eleccion();
            try{
                if(valorInput!=null){
                    int valorAEntero= Convert.ToInt32(valorInput);
                    elegir.EleccionUsuario(valorAEntero);
                }
            }catch(Exception e){ WriteLine(e);}
        }
    }

    class Eleccion{
        public void EleccionUsuario(int num){
            switch(num){
                case 1:
                var ejercicio1= new Ejercicio_1();
                ejercicio1.MenorMayor();
                break;
                case 2:
                var ejercicio2= new Ejercicio_2();
                ejercicio2.ParImpar();
                break;
                case 3:
                var ejercicio3= new Ejercicio_3();
                ejercicio3.AnyoBisiesto();
                break;
                case 4:
                var ejercicio4= new Ejercicio_4();
                ejercicio4.palindromo();
                break;
                case 5:
                var ejercicio5= new Ejercicio_5();
                ejercicio5.ordenarLista();
                break;
                case 6:
                var ejercicio6= new Ejercicio_6();
                ejercicio6.factorial();
                break;
                case 7:
                var ejercicio7= new Ejercicio_7();
                ejercicio7.NumeroPrimo();
                break;
                case 8:
                var ejercicio8= new Ejercicio_8();
                ejercicio8.AreaVolumenCubo();
                break;
                case 9:
                var ejercicio9= new Ejercicio_9();
                ejercicio9.SumaNumerosPares();
                break;
                case 10:
                var ejercicio10= new Ejercicio_10();
                ejercicio10.NumeroPositivoNegativoCero();
                break;
                case 11:
                var ejercicio11= new Ejercicio_11();
                ejercicio11.MediaLista();
                break;
                case 12:
                var ejercicio12= new Ejercicio_12();
                ejercicio12.AdivinarNumero();
                break;
                case 13:
                var ejercicio13= new Ejercicio_13();
                ejercicio13.Anagrama();
                break;
                case 14:
                var ejercicio14= new Ejercicio_14();
                ejercicio14.EliminarDuplicados();
                break;
                case 15:
                var ejercicio15= new Ejercicio_15();
                ejercicio15.Capicua();
                break;
            }
        }
    }

    class DiferentesEjercicios{
//         public void MenorMayor()
// {

//     int[] numeros = { 5, 3, 8, 1, 7, 2 };
//     int mayor = numeros[0];
//     int menor = numeros[0];

//     foreach (int numero in numeros)
//     {
//         if (numero > mayor)
//         {
//             mayor = numero;
//         }
//         if (numero < menor)
//         {
//             menor = numero;
//         }
//     }

//     WriteLine("El mayor número es: " + mayor);
//     WriteLine("El menor número es: " + menor);
//     ReadLine();
// }

// void ParImpar()
// {
//     int numero = 0;
//     Write("Ingrese un número entero: ");
//     if (int.TryParse(ReadLine(), out numero))
//         if (numero % 2 == 0)
//         {
//             WriteLine("El número es par");
//         }
//         else
//         {
//             WriteLine("El número es impar");
//         }
//     else
//     {
//         WriteLine("Ha entrado un número erroneo");
//     }
// }

// void AnyoBisiesto()
// {
//     Write("Ingrese un año: ");
//     int anio = 0;
//     if (int.TryParse(ReadLine(), out anio))

//         if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
//         {
//             WriteLine(anio + " es un año bisiesto");
//         }
//         else
//         {
//             WriteLine(anio + " no es un año bisiesto");
//         }
//     else
//         WriteLine("Ha entrado un año incorrecto");
// }

// void palindromo()
// {
//     Write("Ingrese una palabra o frase: ");
//     string? texto = ReadLine();
//     if (texto == null)
//     {
//         Write("Texto invalido");
//         return;
//     }
//     texto = texto.ToLower().Replace(" ", "");
//     bool palindromo = true;
//     for (int i = 0; i < texto.Length / 2; i++)
//     {
//         if (texto[i] != texto[texto.Length - 1 - i])
//         {
//             palindromo = false;
//             break;
//         }
//     }

//     if (palindromo)
//     {
//         WriteLine("La cadena es un palíndromo");
//     }
//     else
//     {
//         WriteLine("La cadena no es un palíndromo");
//     }

// }

// void ordenarLista()
// {
//     string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

//     Array.Sort(nombres);

//     WriteLine("Lista ordenada alfabéticamente:");

//     foreach (string nombre in nombres)
//     {
//         WriteLine(nombre);
//     }
// }

// void factorial()
// {
//     int num = 0, factorial = 1;

//     Write("Introduce un número entero positivo: ");
//     if (int.TryParse(ReadLine(), out num))
//     {

//         for (int i = 1; i <= num; i++)
//         {
//             factorial *= i;
//         }

//         WriteLine("El factorial de {0} es {1}", num, factorial);
//     }
//     else
//         WriteLine("Número inválido");

//     ReadKey();
// }

// void NumeroPrimo()
// {
//     int num = 0, i;
//     bool esPrimo = true;

//     Write("Introduce un número entero positivo: ");
//     if (!int.TryParse(ReadLine(), out num))
//     {
//         WriteLine("Número invalido");
//         return;
//     }

//     for (i = 2; i < num; i++)
//     {
//         if (num % i == 0)
//         {
//             esPrimo = false;
//             break;
//         }
//     }

//     if (esPrimo)
//         WriteLine("{0} es un número primo", num);
//     else
//         WriteLine("{0} no es un número primo", num);
// }

// void AreaVolumenCubo()
// {
//     double lado = 0, area, volumen;

//     Write("Introduce el valor del lado del cubo: ");
//     if (!double.TryParse(ReadLine(), out lado))
//     {
//         WriteLine("Lado invalido");
//         return;
//     }

//     area = 6 * Pow(lado, 2);
//     volumen = Pow(lado, 3);

//     WriteLine("El área del cubo es {0}", area);
//     WriteLine("El volumen del cubo es {0}", volumen);

//     ReadKey();
// }

// void SumaNumerosPares()
// {
//     List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//     int suma = 0;

//     foreach (int num in numeros)
//     {
//         if (num % 2 == 0)
//             suma += num;
//     }

//     WriteLine("La suma de los números pares es {0}", suma);

//     ReadKey();
// }

// void NumeroPositivoNegativoCero()
// {

//     int num;

//     Write("Introduce un número entero: ");
//     if (!int.TryParse(ReadLine(), out num))
//     {
//         WriteLine("Número invalido");
//         return;
//     }

//     if (num > 0)
//         WriteLine("{0} es un número positivo", num);
//     else if (num < 0)
//         WriteLine("{0} es un número negativo", num);
//     else
//         WriteLine("{0} es cero", num);

//     ReadKey();
// }

// void MediaLista()
// {
//     int[] numeros = { 10, 20, 30, 40, 50 };
//     double media = numeros.Average();
//     WriteLine("La media es: " + media);
// }

// void AdivinarNumero()
// {

//     Random random = new Random();
//     int numeroAleatorio = random.Next(1, 101);
//     int intentos = 0;
//     int numeroUsuario = 0;

//     while (numeroUsuario != numeroAleatorio)
//     {
//         WriteLine("Adivina el número (entre 1 y 100):");
//         if (!int.TryParse(ReadLine(), out numeroUsuario))
//         {
//             WriteLine("Número invalido");
//             continue;
//         }
//         intentos++;

//         if (numeroUsuario < numeroAleatorio)
//         {
//             WriteLine("El número introducido es menor que el número aleatorio.");
//         }
//         else if (numeroUsuario > numeroAleatorio)
//         {
//             WriteLine("El número introducido es mayor que el número aleatorio.");
//         }
//     }

//     WriteLine("¡Has acertado el número en " + intentos + " intentos!");
// }

// void Anagrama()
// {
//     string palabra1 = "roma";
//     string palabra2 = "amor";

//     char[] letras1 = palabra1.ToLower().ToCharArray();
//     char[] letras2 = palabra2.ToLower().ToCharArray();

//     Array.Sort(letras1);
//     Array.Sort(letras2);

//     bool sonAnagramas = letras1.SequenceEqual(letras2);

//     if (sonAnagramas)
//     {
//         WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
//     }
//     else
//     {
//         WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
//     }
// }

// void EliminarDuplicados()
// {
//     List<int> numeros = new List<int>() { 10, 20, 30, 20, 50 };

//     List<int> numerosSinDuplicados = new List<int>();

//     foreach (int numero in numeros)
//     {
//         if (!numerosSinDuplicados.Contains(numero))
//         {
//             numerosSinDuplicados.Add(numero);
//         }
//     }

//     WriteLine("Números originales: " + string.Join(", ", numeros));
//     WriteLine("Números originales: " + string.Join(", ", numeros));

// }

// void Capicua()
// {
//     Console.Write("Ingresa un número: ");
//     int num = 0;
//     if (!int.TryParse(ReadLine(), out num))
//     {
//         WriteLine("Número invalido");
//         return;
//     }
//     int originalNum = num;
//     int reversedNum = 0;

//     while (num > 0)
//     {
//         int digit = num % 10;
//         reversedNum = (reversedNum * 10) + digit;
//         num /= 10;
//     }

//     if (originalNum == reversedNum)
//     {
//         Console.WriteLine("El número es capicúa.");
//     }
//     else
//     {
//         Console.WriteLine("El número no es capicúa.");
//     }

    
// }
    }
}