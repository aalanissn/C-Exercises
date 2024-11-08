//class Fibonacci
//{
//    public static void Main(string[] args)
//    {
//        SerieFibonacci();
//    }

//     static void SerieFibonacci()
//    {
//        Console.WriteLine("Seleccionaste la opción 3");
//        Console.WriteLine("Por favor, ingresa un número para calcular Fibonacci hasta el término n:");


//        if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
//        {
//            // Mostrar secuencia de Fibonacci hasta el término n
//            Console.WriteLine($"Secuencia de Fibonacci hasta Fibonacci({num}):");
//            MostrarSecuenciaFibonacci(num);
//        }
//        else
//        {
//            Console.WriteLine("Por favor ingresa un número entero válido mayor a 0.");
//        }
//    }

//    // Función para mostrar la secuencia Fibonacci hasta el término n
//    public static void MostrarSecuenciaFibonacci(int n)
//    {

//        if (n == 1)
//        {
//            Console.WriteLine("1");
//            return;
//        }


//        int a = 1, b = 1;
//        Console.Write($"{a} {b} ");

//        // Calcula los  términos y los Muestra
//        for (int i = 3; i <= n; i++)
//        {
//            int siguiente = a + b;
//            Console.Write($"{siguiente} ");
//            a = b;  // Actualiza los valores de a y b
//            b = siguiente;  // El siguiente término es la suma de los dos anteriores
//        }
//        Console.WriteLine();
//    }
//}
