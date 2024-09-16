using System;
using System.Collections.Generic;

class EjercicioSORTEDHASHSET
{
    static void Main()
    {
        // Crea el conjunto ordenado de frases
        SortedSet<string> frases = new SortedSet<string>();
        string frase;

        // Solicita frases al usuario hasta que introduzca una vacia
        do
        {
            Console.WriteLine("Introduce una frase (deja vacía para terminar):");
            frase = Console.ReadLine();

            // Si la frase no esta vacia, comprobar si ya fue introducida
            if (!string.IsNullOrEmpty(frase))
            {
                if (frases.Contains(frase))
                {
                    Console.WriteLine($"La frase '{frase}' ya fue introducida.");
                }
                else
                {
                    frases.Add(frase);
                    Console.WriteLine($"La frase '{frase}' ha sido añadida.");
                }
            }

        } while (!string.IsNullOrEmpty(frase)); // Repite hasta que la frase este vacia

        Console.WriteLine("Programa finalizado.");
    }
}

