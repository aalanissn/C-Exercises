using System;

public class ProgramasVarios
{
    static void Main()
    {
        Console.WriteLine("Elige la opción de tu elección");
        Console.WriteLine();
        Console.WriteLine("1.- Calculadora Básica usando Switch");
        Console.WriteLine("2.- Calculadora Básica usando If");
        Console.WriteLine("3.- Calcular serie de números Fibonacci");
        Console.WriteLine("4.- Impresión de tablas de multiplicar");
        Console.WriteLine("5.- Calcular salario por semana");
        Console.WriteLine("6.- Aplicación Estacionamiento, calcula horas y monto a pagar");
        Console.WriteLine("7.- Calcular descuento en supermercado");
        Console.WriteLine("8.- Adivina un número");
        Console.WriteLine("9.- Simulador del juego del Ahorcado");
        Console.WriteLine("10.- Calcular áreas");
        Console.WriteLine("11.- Permite calcular el valor a pagar en una caja registradora donde se reciben N productos y se ingresan los precios de uno en uno");
        Console.WriteLine("12.- Permite llenar una matriz y mostrar todos los datos ingresados y su respectiva posición (fila, columna) en pantalla");
        Console.WriteLine("13.- Permite mostrar al usuario si el valor ingresado es par o impar");
        Console.WriteLine("14.- Calcular porcentaje sobre valor");

        int accesoapp;
        double gradosAr, radianes;
         

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
            case 1:
                Console.WriteLine("Tu selección fue: Calculadora Básica usando Switch");
                calculadora();
                break;
            case 2:
                Console.WriteLine("Sleccionaste la opción 2 ");
                calculadoraif();
                break;
            case 3:
                Console.WriteLine("Seleccionaste la Secuencia de Fibonacci");
                SerieFibonacci();
                break;
            case 4:
                Console.WriteLine("Opción 4: Tablas de Multiplicar ");
                TablasXmultiplicar();
                break;
            case 5:
                Console.WriteLine("Seleccionaste Calculadora de Salario Semanal");
                CalculaSalario();
                break;
                case 6:
                Console.Write("Ingresa los grados: ");
                    gradosAr = Convert.ToDouble(Console.ReadLine());
                   radianes = GradosRadianes(gradosAr);
                Console.WriteLine("{0}° = {1} Radianes ", gradosAr, radianes);
                break;
            default:
                Console.WriteLine("Opción no implementada.");
                break;
        }
    }

    static void calculadora() //opción uno
    {
        Console.WriteLine("Selecciona la opción de tu preferencia:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        int calculadora;


        //while (true)  //(If no simplificado)
        //{
        //    if (int.TryParse(Console.ReadLine(), out calculadora) && calculadora >= 1 && calculadora <= 4)
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ingresa una opción válida entre 1 y 4.");
        //    }
        //}

        while (true)  //If simplificado se ahorra líneas de código
        {
            if (int.TryParse(Console.ReadLine(), out calculadora) && calculadora is >= 1 and <= 4)
                break;

            Console.WriteLine("Ingresa una opción válida entre 1 y 4.");
        }


        Console.WriteLine("Ingresa el primer valor:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo valor:");
        int y = Convert.ToInt32(Console.ReadLine());


        switch (calculadora)
        {
            case 1:
                Console.WriteLine("Suma");
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                break;

            case 2:
                Console.WriteLine("Resta");
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                break;

            case 3:
                Console.WriteLine("Multiplicación");
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                break;

            case 4:
                Console.WriteLine("División");
                if (y == 0)
                {
                    Console.WriteLine("No se puede dividir por 0.");
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2}", x, y, (double)x / y);
                }
                break;

            default:
                Console.WriteLine("Ingresa una opción válida.");
                break;
        }
    }

    static void calculadoraif() //Opción dos, calculadora usando Condicional IF
    {

        Console.WriteLine("Ingresa el primer valor");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo valor");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la opción deseada + , -, * , /");
        char operacion = Convert.ToChar(Console.ReadLine());



        if (operacion == '+')
            Console.WriteLine("{0} + {1} = {2} ", a, b, a + b);
        else if (operacion == '-')
            Console.WriteLine("{0} - {1} = {2} ", a, b, a - b);
        else if (operacion == '*' || operacion == 'x')
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        else if (operacion == '/')
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        else Console.WriteLine("Ingresa una opción valida");

    }

    static void SerieFibonacci() //opción 3
    {
        Console.WriteLine("Seleccionaste la opción 3");
        Console.WriteLine("Por favor, ingresa un número para calcular Fibonacci hasta el término n:");


        if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
        {
            // Mostrar secuencia 
            Console.WriteLine($"Secuencia de Fibonacci hasta Fibonacci({num}):");
            MostrarSecuenciaFibonacci(num);
        }
        else
        {
            Console.WriteLine("Por favor ingresa un número entero válido mayor a 0.");
        }
    }

    // Función para mostrar la secuencia Fibonacci 
    public static void MostrarSecuenciaFibonacci(int n)
    {

        if (n == 1)
        {
            Console.WriteLine("1");
            return;
        }


        int a = 1, b = 1;
        Console.Write($"{a} {b} ");

        // Calcula los  términos y los Muestra
        for (int i = 3; i <= n; i++)
        {
            int siguiente = a + b;
            Console.Write($"{siguiente} ");
            a = b;  // Actualiza los valores de a y b
            b = siguiente;  // El siguiente término es la suma de los dos anteriores
        }
        Console.WriteLine();
    }


    static void TablasXmultiplicar()
    {
        int tabla, multiplicador;


        Console.WriteLine("Ingresa el número de la tabla que quieras multiplicar:");

        // Leer el valor ingresado por el usuario y convertirlo a entero
        if (int.TryParse(Console.ReadLine(), out tabla))
        {

            if (tabla > 0)
            {

                for (multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    Console.WriteLine($"{tabla} X {multiplicador} = {tabla * multiplicador}");
                }
            }
            else
            {
                Console.WriteLine("Por favor ingresa un número positivo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa un número válido.");
        }

        Console.Read();
    }

    static void CalculaSalario() //opción 5 calcula salario semanal 
    {

        Console.WriteLine("Ingresa el total de horas trabajadas a la semana");
        int hrs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa tu salario total por día");
        decimal salarioDiario = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("{0} * {1} = {2} ", hrs, salarioDiario, hrs * salarioDiario);

    }


    static double GradosRadianes(double gradosPA)
    {
      
        double radianes;
        radianes = (gradosPA * Math.PI) / 180;

        return radianes;


    }





}

