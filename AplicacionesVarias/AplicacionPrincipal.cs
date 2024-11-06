using System;


public class ProgramasVarios
{

    static void Main()
    {

        Console.WriteLine("1.- Elige la opción de tu elección");
        Console.WriteLine("2.- Calculadora Básica usando Switch");
        Console.WriteLine("3.- Calculadora Básica usando If");
        Console.WriteLine("4.- Calcular serie de números Fibonacci");
        Console.WriteLine("5.- Impresión de tablas de multiplicar");
        Console.WriteLine("6.- Calcular salario por semana");
        Console.WriteLine("7.- Aplicación Estacionamiento, calcula horas y monto a pagar");
        Console.WriteLine("8.- Calular descuento en supermercado");
        Console.WriteLine("9.- Adivina un número");
        Console.WriteLine("10.- Simulador del juego del Ahorcado");
        Console.WriteLine("11.- Calcular áreas");
        Console.WriteLine("12.- Permita calcular el valor apagar en una caja registradora donde se reciben N productos y se ingresan los preciosde uno en uno");
        Console.WriteLine("13.- Permite llenar una matriz y mostrar todos los datos ingreados y su respectiva posición (fila,columna) en pantalla");
        Console.WriteLine("14.- Permite mostrar al usuario si el valor ingresado es par o impar");
        Console.WriteLine("15.- Calcular porcentaje sobre valor");
        

        int accesoapp;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out accesoapp) && accesoapp >= 1 && accesoapp <= 15)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingresa una opción válida");
            }
        }

        switch (accesoapp)
        {
            



        }


    }
}
    
