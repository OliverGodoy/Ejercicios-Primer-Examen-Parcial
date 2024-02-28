/* 1.- Escribir un programa que le pida al usuario un número entero positivo y le 
muestre un menú con las siguientes opciones:
1.Calcular el factorial del número.
2. Calcular la raíz cuadrada del número.
3. Salir del programa.
El usuario debe poder elegir una opción y repetir el proceso hasta que elija salir*/

int opcion;

Console.Write("Ingrese un número entero prositivo: ");
int num1 = int.Parse(Console.ReadLine());
do
{
    Console.WriteLine("\t.:MENÚ:.");
    Console.Write("\n1. Calcular el factorial del número ");
    Console.Write("\n2. Calcular la raíz cuadrada del número ");
    Console.Write("\n3. Salir ");
    Console.Write("\nElija la opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("\nCalculando factorial del número...");
            int factorial = 1;

            for (int i = 1; i <= num1; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial de {0} es {1}", num1, factorial);
            break;
        case 2:
            Console.WriteLine("\nCalculando la raíz cuadrada del número...");
            double raizCuadrada = System.Math.Sqrt(num1);

            Console.WriteLine("La raíz cuadrada de {0} es {1}", num1, raizCuadrada);
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (opcion != 3);
Console.Clear();

/* 2.- Escribir un programa que solicite al usuario dos números enteros y un operador 
matemático (+, -, *, /). El programa debe realizar la operación indicada y mostrar el 
resultado, validando que los datos sean correctos y el operador sea válido. */
int num2;
int num3;
try
{
    Console.Write("Ingrese el primer número entero: ");
    num2 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    num3 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el operador matemático (+,-,*,/): ");
    string operador = Console.ReadLine();

    // Validar el operador
    if (!ValidarOperador(operador))
    {
        Console.WriteLine("Operador no válido.");
        return;
    }

    //Realizar Operación
    int resultado = 0;
    switch (operador)
    {
        case "+":
            resultado = num2 + num3;
            break;
        case "-":
            resultado = num2 - num3;
            break;
        case "*":
            resultado = num2 * num3;
            break;
        case "/":
            // Validar la división por cero
            if (num3 == 0)
            {
                Console.WriteLine("División por cero no válida.");
                return;
            }
            resultado = num2 / num3;
            break;
    }
    Console.WriteLine("El resultado de la operación {0} {1} {2} es {3}", num2, operador, num3, resultado);

    static bool ValidarOperador(string operador)
    {
        return operador == "+" || operador == "-" || operador == "*" || operador == "/";
    }
}
catch (FormatException)
{
    Console.WriteLine("¡El valor introducido no es un número!");
    Console.ReadKey();
    Console.Clear();
}
Console.ReadKey();
Console.Clear();

/* 3.- Escribir un programa que imprima una tabla de multiplicar del 1 al 10 para un número 
introducido por el usuario. */

Console.WriteLine("\t.:Tabla de multiplicar (1-10):.");
Console.Write("\nIngrese el número que desea ver su respectiva tabla de multiplicar (1-10)");
int num4 = int.Parse(Console.ReadLine());

Console.WriteLine("Tabla de múltiplicar del {0}: ", num4);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", num4, i, num4 * i);
}
Console.ReadKey();
Console.Clear();

/* 4.Escribir un programa que adivine un número secreto entre 1 y 100. El usuario debe ir 
introduciendo números y el programa le indicará si el número secreto es mayor o menor 
que el introducido. El programa debe terminar cuando el usuario adivine el número 
secreto */

// Generar un número aleatorio entre 1 y 100
Random random = new Random();
int numeroAl = random.Next(1, 101);
Console.WriteLine("\tAdivinar número secreto ");
int numeroUsuario;
int contador = 0;
do
{
    Console.Write("Ingrese un número entre 1 y 100:");
    numeroUsuario = int.Parse(Console.ReadLine());

    if (numeroUsuario < numeroAl)
    {
        Console.WriteLine("El número es mayor");
    }
    else if (numeroUsuario > numeroAl)
    {
        Console.WriteLine("El número es menor");
    }
    contador ++;
} while (numeroUsuario != numeroAl);

Console.WriteLine("¡Felicidades! Adivinaste el número");
Console.Write("Número de intentos: " + contador);
Console.ReadLine();

