using System;
using System.Collections.Generic;
using System.Globalization; // Necesario para CultureInfo

class Calculadora
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Desea realizar operaciones con números enteros (1) o decimales (2)?");
        int tipoNumero = 0;
        try
        {
            tipoNumero = int.Parse(Console.ReadLine()); // Lee la entrada del usuario y la convierte en un número entero
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Entrada no válida. Debe ingresar un número.");
            return;
        }

        List<string> registroOperaciones = new List<string>(); // Lista para registrar las operaciones realizadas

        while (true)
        {
            Console.WriteLine("..........-CALCULADORA- -•*.•......."); // Título de la calculadora
            Console.WriteLine("\nMenú de operaciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Ver Registro"); // Opción para ver el registro de operaciones
            Console.WriteLine("0. Salir");

            int opcion = 0;
            try
            {
                opcion = int.Parse(Console.ReadLine()); // Lee la opción seleccionada por el usuario
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Debe ingresar un número.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    RealizarOperacion(tipoNumero, '+', (a, b) => a + b, registroOperaciones); // Llama al método para realizar la operación de suma
                    break;
                case 2:
                    RealizarOperacion(tipoNumero, '-', (a, b) => a - b, registroOperaciones); // Llama al método para realizar la operación de resta
                    break;
                case 3:
                    RealizarOperacion(tipoNumero, '*', (a, b) => a * b, registroOperaciones); // Llama al método para realizar la operación de multiplicación
                    break;
                case 4:
                    RealizarOperacion(tipoNumero, '÷', (a, b) => // Llama al método para realizar la operación de división
                    {
                        if (b == 0)
                        {
                            registroOperaciones.Add($"¡Error! No se puede dividir por cero.");
                            return double.NaN;
                        }
                        return a / b;
                    }, registroOperaciones);
                    break;
                case 5:
                    VerRegistro(registroOperaciones); // Llama al método para ver el registro de operaciones
                    break;
                case 0:
                    Console.WriteLine("¡Gracias por usar la calculadora!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void RealizarOperacion(int tipoNumero, char simboloOperacion, Func<double, double, double> operacion, List<string> registroOperaciones)
    {
        Console.Clear(); // Limpia la pantalla
        double num1 = 0, num2 = 0;
        try
        {
            Console.WriteLine("Ingrese el primer número:");
            // Permitir "," y "." como separador decimal
            num1 = Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture); // Lee el primer número y convierte la coma en punto para la entrada decimal

            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture); // Lee el segundo número y convierte la coma en punto para la entrada decimal
        }
        catch (FormatException)
        {
            registroOperaciones.Add($"¡Error! Entrada no válida. Debe ingresar un número.");
            return;
        }

        double resultado;
        try
        {
            resultado = operacion(num1, num2); // Realiza la operación matemática seleccionada
            registroOperaciones.Add($"{num1} {simboloOperacion} {num2} = {(tipoNumero == 1 ? (int)resultado : resultado)}"); // Agrega la operación al registro
        }
        catch (Exception ex)
        {
            registroOperaciones.Add($"¡Error! {ex.Message}"); // Agrega mensajes de error al registro de operaciones
        }
    }

    static void VerRegistro(List<string> registroOperaciones)
    {
        Console.Clear(); // Limpia la pantalla
        Console.WriteLine("Registro de operaciones:");
        foreach (var operacion in registroOperaciones)
        {
            Console.WriteLine(operacion); // Muestra el registro de operaciones en la consola
        }
    }
}

