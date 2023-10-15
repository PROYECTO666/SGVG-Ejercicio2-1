using System;

public class Program
{
    public static void Main()
    {
        //SERGIO GUSTAVO VALENCIA GONZALES
        //EJERCICIO 2.2
        //Se puede mejorar el codigo convirtiendo la respuesta en Minuscula y asi sería menos líneas de código
        Console.Write("Te gustaría ir al Concierto: ");
        string variableEncuesta = Convert.ToString(Console.ReadLine());
        if (variableEncuesta == "SI" || variableEncuesta == "si" ) {
            Console.WriteLine("Hay Conciertos para 'Paramore', 'AC/DC'");
            
        }  else if (variableEncuesta == "NO" || variableEncuesta == "no") {
            Console.WriteLine("Elejiste la opción NO, Muchas Gracias por responder");
        }  else if (variableEncuesta != "SI" || variableEncuesta != "NO" || variableEncuesta != "si" || variableEncuesta != "no")
        {
            Console.WriteLine("Vuleve Pronto");
        }

    }
}