using System;

class Calculadora
{

    static void Main(string[] args)
    {
        // Preguntar si se desea trabajar con números enteros o decimales
        Console.WriteLine("¿Desea realizar operaciones con números enteros (1) o decimales (2)?");
        int tipoNumero = int.Parse(Console.ReadLine());

        // Bucle principal del programa
        while (true)
        {
            // Mostrar el menú de operaciones
            Console.WriteLine("..........-CALCULADORA- -•*.•.......");
            Console.WriteLine("\nMenú de operaciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");

            // Leer la opción seleccionada
            int opcion = int.Parse(Console.ReadLine());

            // Realizar la operación seleccionada
            switch (opcion)
            {
                case 1:
                    Sumar(tipoNumero);
                    break;
                case 2:
                    Restar(tipoNumero);
                    break;
                case 3:
                    Multiplicar(tipoNumero);
                    break;
                case 4:
                    Dividir(tipoNumero);
                    break;
                case 0:
                    Console.WriteLine("¡Gracias por usar la calculadora!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            // Limpiar la pantalla antes de volver al menú principal
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void Sumar(int tipoNumero)
    {
        Console.Clear(); // Limpiar la pantalla
        Console.WriteLine("Ingrese el primer número:");
        double num1 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine("La suma es: " + (tipoNumero == 1 ? (int)resultado : resultado));
    }

    static void Restar(int tipoNumero)
    {
        Console.Clear(); // Limpiar la pantalla
        Console.WriteLine("Ingrese el primer número:");
        double num1 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine("La resta es: " + (tipoNumero == 1 ? (int)resultado : resultado));
    }

    static void Multiplicar(int tipoNumero)
    {
        Console.Clear(); // Limpiar la pantalla
        Console.WriteLine("Ingrese el primer número:");
        double num1 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine("La multiplicación es: " + (tipoNumero == 1 ? (int)resultado : resultado));
    }

    static void Dividir(int tipoNumero)
    {
        Console.Clear(); // Limpiar la pantalla
        Console.WriteLine("Ingrese el primer número:");
        double num1 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = tipoNumero == 1 ? double.Parse(Console.ReadLine()) : double.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("¡Error! No se puede dividir por cero.");
            return;
        }

        double resultado = num1 / num2;
        Console.WriteLine("La división es: " + (tipoNumero == 1 ? (int)resultado : resultado));
    }
}