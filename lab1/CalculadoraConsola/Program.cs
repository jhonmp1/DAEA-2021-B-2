using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static int Resta(int c, int d)
        {
            return c - d;
        }
        static int Multiplicacion(int e, int f)
        {
            return e * f;
        }
        static double Divicion(double g, double h)
        {
            if(h<= 0.0) {
                return 0.0;
            }
            else
            {
                return g / h;
            }
        }
        static void Primos()
        {
            int cont = 0;
            for (int i = 2; i <= 30; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                { 
                    Console.WriteLine(i);
                }
                cont = 0;
            }
        }
        static double Celcius(double far)
        {
            double celcius = (5*(far - 32)) / 9;
            return celcius;
        }
        static double Fahrenheit(double cel)
        {
            double fahrenheit = ((9*cel)/5)+32;
            return fahrenheit;
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y Funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos numeros");
                Console.WriteLine("[2] Raiz de 10 primeros numeros");
                Console.WriteLine("[3] Resta de dos numeros");
                Console.WriteLine("[4] Multiplicacion entre dos numeros");
                Console.WriteLine("[5] Divicion entre dos numeros");
                Console.WriteLine("[6] 10 primeros numeros primos");
                Console.WriteLine("[7] Fahrenheit a Celcius");
                Console.WriteLine("[8] Celcius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y precione enter");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b,Suma(a,b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer numero");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer numero");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer numero");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int h= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La divicion de {0} y {1} es {2}", g, h, Divicion(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Calculando");
                        Console.WriteLine("Ingrese el primer numero");
                        int far = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} es {1}", far, Celcius(far));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el primer numero");
                        int cel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} es {1}", cel, Fahrenheit(cel));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
            
        }
    }
}
