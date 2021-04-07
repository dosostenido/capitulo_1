using System;
class Area_circulo
{
    static void Main()
    {
        // Declaración de la variable radio:
        int radio;
        // Declaración e inicialización de la constante pi:
        const double pi = 3.1416;
        Console.Write("Ingrese el radio del círculo: ");
        // Conversión de cadena a entero y asignación de la variable radio:
        radio = Convert.ToInt32(Console.ReadLine());
        Console.Write("El área del círculo es: ");
        // Evalúa y despliega una expresión en consola:
        Console.WriteLine(pi * radio * radio);
    }
}