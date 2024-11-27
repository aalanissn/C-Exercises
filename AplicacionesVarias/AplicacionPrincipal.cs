using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace AplicacionesVarias
{

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
            Console.WriteLine("6.- Calcula de Grados a radianes");
            Console.WriteLine("7.- Calculadora de áreas figuras geometricas");
            Console.WriteLine("8.- Adivina un número");
            Console.WriteLine("9.- Simulador del juego del Ahorcado");
            Console.WriteLine("10.- Imprime abecedario");
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
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}!");
                    calculadora();
                    break;
                case 2:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}!");
                    calculadoraif();
                    break;
                case 3:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}!");
                    SerieFibonacci();
                    break;
                case 4:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}!");
                    TablasXmultiplicar();
                    break;
                case 5:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}!");
                    CalculaSalario();
                    break;
                case 6:
                    Console.Write("Ingresa los grados: ");
                    gradosAr = Convert.ToDouble(Console.ReadLine());
                    radianes = GradosRadianes(gradosAr);
                    Console.WriteLine("{0}° = {1} Radianes ", gradosAr, radianes);
                    break;
                case 7:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}!");
                    calculadoradeAreas();
                    break;
                case 8:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}!");
                    AdivinaelNumero();
                    break;
                case 9:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}");
                    Ahorcado();
                    break;
                case 10:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}");
                    Abecedario();
                    break;
                case 11:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}");
                    ProductosTienda();
                    break;
                case 12:
                    Console.WriteLine($"Seleccionaste la opción {accesoapp}");
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

        static void calculadoradeAreas() //Opción 7

        {
            double area, radiopa, lado, baseTriangulo, alturaTriangulo;

            while (true)
            {
                Console.WriteLine("¿Qué área desea calcular?");
                Console.WriteLine("1.- Cuadrado");
                Console.WriteLine("2.- Círculo");
                Console.WriteLine("3.- Triángulo");

                int seleccion;
                if (int.TryParse(Console.ReadLine(), out seleccion) && seleccion >= 1 && seleccion <= 3)
                {
                    if (seleccion == 1)  // Cuadrado
                    {
                        Console.WriteLine("Introduce el lado del cuadrado:");
                        lado = Convert.ToDouble(Console.ReadLine());
                        area = lado * lado;
                        Console.WriteLine("El área del cuadrado es: " + area);
                    }
                    else if (seleccion == 2)  // Círculo
                    {
                        Console.WriteLine("Introduce el radio del círculo:");
                        radiopa = Convert.ToDouble(Console.ReadLine());
                        area = Math.PI * (radiopa * radiopa);
                        Console.WriteLine("El área del círculo es: " + area);
                    }
                    else if (seleccion == 3)  // Triángulo
                    {
                        Console.WriteLine("Introduce la base del triángulo:");
                        baseTriangulo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triángulo:");
                        alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                        area = (baseTriangulo * alturaTriangulo) / 2;
                        Console.WriteLine("El área del triángulo es: " + area);
                    }

                    Console.WriteLine("¿Deseas calcular otra área? (s/n)");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta != "s")
                        break;
                }
                else
                {
                    Console.WriteLine("Ingresa una opción válida entre 1 y 3.");
                }
            }
        }

        static void AdivinaelNumero() //opción 8 
        {
            int num, usuario, intentos, min, max;
            Random rand = new Random(); //se crea obj de tipo random aleatorio
            intentos = 0;
            min = 1;
            max = 100;
            num = rand.Next(min, max + 1); //Generación del número aleatorio para que el número esté en el rango de min a max (incluyendo ambos).

            do
            {

                Console.WriteLine($"Ingresa un número entre {min} y {max}:");
                usuario = Convert.ToInt32(Console.ReadLine());
                intentos++;

                if (num > usuario)
                    Console.WriteLine("El número que buscas es mayor");
                else if (num < usuario)
                    Console.WriteLine("El número que buscas es menor");

                else
                {
                    Console.WriteLine($"¡Felicidades, adivinaste el número {num} en {intentos} intentos!");
                    break;
                }
            } while (true);
        }

        static void Ahorcado() //Opcion 9
        {
            string[] palabras = { "artículo", "canasta", "carrito", "descuento", "precio", "oferta" };  //palabras a adivianr
            Random rand = new Random();
            int num = rand.Next(palabras.Length);             //generador al azar de la palabra
            string palabraAdivinar = palabras[num];
            int fallosRestantes = 8;
            char letraActual;
            bool terminado = false;

            // Preparamos una palabra a mostrar (serie de guiones: ---- ----) desde ella
            string palabraMostrar = "";
            for (int i = 0; i < palabras.Length; i++)
                if (palabraAdivinar[i] == ' ')
                    palabraMostrar += " ";
                else
                    palabraMostrar += "-";
            do
            {
                // Mostramos la palabra oculta (y los fallos restantes)
                Console.WriteLine("Palabra oculta:  " + palabraMostrar);
                Console.WriteLine("Fallos restantes: " + fallosRestantes);

                // El usuario elige una letra
                Console.Write("Introduzca una letra: ");
                letraActual = Convert.ToChar(Console.ReadLine());

                // Si la letra no es parte de la palabra, el jugador pierde un intento (de los ocho iniciales)
                if (!palabraAdivinar.Contains(letraActual))
                    fallosRestantes--;

                // Si la letra es parte de la palabra, el jugador no 
                // pierde ningún intento, y la letra se muestra como
                // parte de la palabra oculta: --a- -a--
                string siguienteMostrar = "";

                for (int i = 0; i < palabraAdivinar.Length; i++)
                {
                    if (letraActual == palabraAdivinar[i])
                        siguienteMostrar += letraActual;
                    else
                        siguienteMostrar += palabraMostrar[i];
                }
                palabraMostrar = siguienteMostrar;

                // Comprobamos si ha terminado: si el usuario se queda sin intentos
                // o si adivina toda la palabra.
                if (!palabraMostrar.Contains("-"))
                {
                    Console.WriteLine("Felicidades, acertaste!  ({0})",
                        palabraAdivinar);
                    terminado = true;
                }
                else if (fallosRestantes == 0)
                {
                    Console.WriteLine("Lo siento. Era " + palabraAdivinar);
                    terminado = true;
                }

                Console.WriteLine();

            }
            while (!terminado);
        }


        static void Abecedario() //opción 10
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


        static void ProductosTienda() //opción 11

        {
            int productos;
            double precioproducts, total = 0;

            Console.WriteLine("Ingresa la cantidad de artículos a llevar");
            productos = Convert.ToInt32(Console.ReadLine());

            if (productos > 0)

            {
                for (int i = 0; i < productos; i++)
                {
                    Console.WriteLine($"Ingresa el precio del producto {i + 1}:");
                    precioproducts = Convert.ToDouble(Console.ReadLine());
                    total += precioproducts;

                }

                Console.WriteLine($"El total de la compra es: {total:C}");


            }
            else
            {
                Console.WriteLine("Ingresa una cantidad de productos mayor a 0");
            }


        }

        static void opción12()
        { 
                 int columnas = 3;
                 int filas = 0;
        
        }
    }
}

