using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana3_Proyecto_Usando_Estructuras_De_Control_En_Consola
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Proyecto de Menu");
            System.Console.WriteLine("Primer Programa Usando Estructuras");

            System.Console.ReadKey();

            int repetir;

            //menu_interno();

            do
            {
                menu_interno();
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Ingrese 1 para repetir menú");
                System.Console.WriteLine("Ingrese 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);

        } //Cierre de función principal


        //Inicio de funciones interna
        static void menu_interno()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menu Principal");
            System.Console.WriteLine("1. Ejemplo If");
            System.Console.WriteLine("2. Ejemplo Switch");
            System.Console.WriteLine("3. Ejemplo For");
            System.Console.WriteLine("4. Ejemplo While");
            System.Console.WriteLine("5. Ejemplo Do While");

            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);

            switch (opcionint)
            {
                case 1:

                    //llamada función interna
                    programa_if();
                    break;

                case 2:
                    //llamada de función interna
                    programa_switch();
                    break;

                case 3:
                    //llamada de función interna
                    programa_for();
                    break;

                case 4:
                    //llamada de función interna
                    programa_while();
                    break;
                case 5:
                    //llamada de función interna
                    programa_dowhile();
                    break;

                default:
                    //opcion que no existe en el menu
                    System.Console.WriteLine("Opcion no disponible");
                    break;
            }

        }

        //Función interna para ejemplo if
        static void programa_if()
        {
            System.Console.WriteLine("Haz elegido la opción If");
            //pide dos valores, luego compara cual de los dos valores es mayor e imprime el resultado.
            int num1, num2;
            string linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            if (num1 > num2)
            {
                Console.Write(num1);
            }
            else
            {
                Console.Write("El numero mayor es: ");
                Console.Write(num2);
                linea = Console.ReadLine();
            }

            Console.ReadKey();
        }

        //Función interna para ejemplo switch
        static void programa_switch()
        {
            System.Console.WriteLine("Haz elegido la opción Switch");
            string myInput;
            int myInt;
            Console.Write("Dame un número: ");

            myInput = Console.ReadLine();
            myInt = Int32.Parse(myInput);

            switch (myInt)
            {
                case 1:
                    Console.WriteLine("primera opción");
                    break;
                case 2:
                    Console.WriteLine("segunda opción");
                    break;
                case 3:
                    Console.WriteLine("tercera opción");
                    break;
                case 4:
                    Console.WriteLine("cuarta opción");
                    break;
                default:
                    Console.WriteLine("opción por defecto");
                    break;


            }
        }

        //Función interna para ejemplo for
        static void programa_for()
        //Crear un programa que solicite la base y la altura de un cuadrilátero y que lo dibuje con asteriscos (*).
        {
            System.Console.WriteLine("Haz elegido la opción For");
            // Declaramos nuestras variables
            int xbase;
            int height;

            // Solicitamos los datos al usuario
            Console.Write("Ingrese la base del cuadrilátero: ");
            xbase = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del cuadrilátero: ");
            height = int.Parse(Console.ReadLine());

            // El primero será la altura del cuadrilátero
            // Mientras que el segundo será la base
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < xbase; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Función interna para ejemplo while
        static void programa_while()
        {
            System.Console.WriteLine(" Haz elegido la opción While");
            //Primero se pide el ingreso de 2 números, luego se evalúa si el primer numero es menor que el segundo.
            //imprime la cantidad de números que hay de diferencia entre los 2.
            //empezando desde el valor del primer número hasta un número antes que el segundo numero.
            Console.WriteLine("Ingrese un número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número mayor que el anterior: ");
            int num2 = int.Parse(Console.ReadLine());
            while (num1 < num2)

            {
                Console.WriteLine("valores:" + num1);
                num1++;
            }
        }

        //Función interna para ejemplo dowhile
        static void programa_dowhile()
        {
            System.Console.WriteLine("Haz elegido la opción Do While");
            string secreta;
            string palabra;
            Console.WriteLine("ingrese la palabra secreta");
            secreta = Console.ReadLine();
            do
            {
                Console.WriteLine("vuelva a introducir la palabra secreta");
                palabra = Console.ReadLine();
                if (palabra != secreta)
                    Console.WriteLine("palabra incorrecta");
            } while (palabra != secreta);

            Console.WriteLine("Palabra Correcta");
            Console.ReadKey();
        }


    }
}
