using System;

public class Imprime_Abecedario
{
    static void Main(string[] args)
    {
        
        string[] abc = new string[26];

        
        int index = 0;
        for (char c = 'A'; c <= 'Z'; c++)
        {
            abc[index] = c.ToString(); 
            index++;
        }

        // Imprimir el arreglo
        foreach (string letra in abc)
        {
            Console.WriteLine(letra);
        }

      
        Console.WriteLine("Longitud del arreglo: " + abc.Length);
    }
}
