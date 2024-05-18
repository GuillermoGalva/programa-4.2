using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¿Cuántos triángulos deseas ingresar?");
        int n = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingresa la base del triángulo {i + 1}: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.Write($"Ingresa la altura del triángulo {i + 1}: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double superficie = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine($"Triángulo {i + 1} - Base: {baseTriangulo}, Altura: {alturaTriangulo}, Superficie: {superficie}");

            if (superficie > 12)
            {
                contador++;
            }
        }

        Console.WriteLine($"La cantidad de triángulos cuya superficie es mayor a 12 es: {contador}");
    }
}
