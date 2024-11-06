using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionesVarias
{
     class calculadoraSwift
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Selecciona la opción de tu preferencia:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            int calculadora;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out calculadora) && calculadora >= 1 && calculadora <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingresa una opción válida entre 1 y 4.");
                }
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



    }
}
