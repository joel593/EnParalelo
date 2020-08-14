/*using System;

namespace CalculadoraDeber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su primer número: ");
            int primerNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el signo de opración: ");
            double resultado;
            string signo;
            signo = Console.ReadLine();
            switch (signo) 
            {
                case "+":
                    {
                        resultado = (primerNumero + segundoNumero);
                        Console.WriteLine($"El resultado de la operación es: {resultado}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case "-":
                    {
                        resultado = (primerNumero - segundoNumero);
                        Console.WriteLine($"El resultado de la operación es: {resultado}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case "*":
                    {
                        resultado = (primerNumero * segundoNumero);
                        Console.WriteLine($"El resultado de la operación es: {resultado}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case "/":
                    {
                        resultado = (primerNumero / segundoNumero);
                        Console.WriteLine($"El resultado de la operación es: {resultado}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
*/
using System;

namespace CalculadoraDeber
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            string resp = "";
            do
            {
                int primerNumero = 0;
                int segundoNumero = 0;
                int resultado = 0;

                Console.WriteLine("Presione el simbolo para realizar la operacion: ");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("Eliga una opción: ");

                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);

                Console.WriteLine("Ingrese sus dos numeros");
                Console.Write("Primer número: ");
                primerNumero = int.Parse(Console.ReadLine());

                Console.Write("Segundo número: ");
                segundoNumero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (eleccion)
                {
                    case "+":
                        { 
                            Console.WriteLine("El resultado de la suma es:");
                            resultado = primerNumero + segundoNumero;
                            Console.WriteLine("{0} + {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("El resultado de la resta es:");
                            resultado = primerNumero - segundoNumero;
                            Console.WriteLine("{0} - {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine("El resultado de la multiplicación es:");
                            resultado = primerNumero * segundoNumero;
                            Console.WriteLine("{0} * {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("El resultado de la dicisión es:");
                            resultado = primerNumero / segundoNumero;
                            Console.WriteLine("{0} / {1} = {2}", primerNumero, segundoNumero, resultado);
                            break;
                        }
                }
                Console.Write("¿Desea Continuar? S/N: ");
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s") ;
        }
    }
}
