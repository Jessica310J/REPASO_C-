using System;
namespace MiPrimerProyecto
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hola, Mundo");
            int edad = 20;
            Console.WriteLine($"Mi Edad es: {edad}");
            double precio = 19.99;
            Console.WriteLine($"eL precio es:{ precio }");
            char letra = 'A';
            Console.WriteLine($"La letra es:{ letra }");
            bool esMayorDeEdad = true;
            Console.WriteLine($"¿Es mayor de edad: {esMayorDeEdad}");
            

            //--- EJERCICIO: Modifica el valor de una variable existente---
            edad =  21;
            Console.WriteLine($"Ahora mi edad es:{edad}");

            //--- OPERACIONES ARITMÉTICAS ---
            int a = 10;
            int b = 3;
            Console.WriteLine($"\n--- OPERACIONES CON ENTEROS --- ");
            Console.WriteLine($"suma :{a} + {b} = {a + b}");
            Console.WriteLine($"resta:{a} - {b} = {a - b}");
            Console.WriteLine($"Multiplicacion: {a} * {b} = {a*b}");
            Console.WriteLine($"Division entera : {a} / {b} = {a / b }");
            Console.WriteLine($"Modulo(resto) : {a} % {b} = {a % b}");

        }
    }
}

