using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Escribe primer Número: ");
        int num1 = int.Parse(Console.ReadLine());
        if (num1 % 3 == 1)
        {
            Console.WriteLine("El residuo del Numero " + num1 + " entre 3 es igual a 1");
        }
        else
        {
            Console.WriteLine("El residuo no es igual a 1");
        }
    }
}