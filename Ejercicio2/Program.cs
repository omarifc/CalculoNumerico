using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declaración de variables
            float num1, num2, suma, resta, division, multiplicacion;
            #endregion

            // Ingreso de datos
            Console.WriteLine("Ingrese el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = float.Parse(Console.ReadLine()); 
            
            // Operaciones
            suma = num1 + num2;
            Console.WriteLine("La suma de ambos números es: " + suma);

            resta = num1 - num2;
            Console.WriteLine("La resta de ambos números es: " + resta);

            division = num1 / num2;
            Console.WriteLine("La división de ambos números es: " + division);

            multiplicacion = num1 * num2;
            Console.WriteLine("La multiplicación de ambos números es: " + multiplicacion);

            Console.ReadKey();
        }
    }
}
