using System;
using System.Collections.Generic; // Esto "importa" los HashSets

// Creamos un HashSet de tipo string (texto)
var misHobbies = new HashSet<string>();

misHobbies.Add("Piano");
misHobbies.Add("Cantar");
misHobbies.Add("Dibujar");
misHobbies.Add("Piano");

Console.WriteLine($"Cuantos Hobbies hay en total? {misHobbies.Count}");

    if (misHobbies.Contains("Piano"))
    {
        Console.WriteLine ("Si Piano , esta en la lista");
    }
    
    else
    {
            Console.WriteLine("Nuevo Hobbie por aprender");
    }
    
    
   




