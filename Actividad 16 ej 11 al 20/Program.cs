Console.WriteLine("Actividad 11 ej 11 al 20");
Console.WriteLine("Ej ");
Console.WriteLine("Elija una opción:");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 11:
        Console.WriteLine("Ejercicio 11");
        int total11 = 0;
        int i11 = 1;
        do
        {
            Console.WriteLine("Ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            total11 = total11 + num1;
            i11++;
        }
        while (i11 <= 5);
        Console.WriteLine($"El total es {total11} ");
        break;
    case 12:
        Console.WriteLine("Ejercicio 12");
        int total12 = 0;
        int num12;
        do
        {
            Console.WriteLine("Ingrese un numero");
            num12 = int.Parse(Console.ReadLine());
            total12 = total12 + num12;
        }
        while (num12 != 0);
        Console.WriteLine($"El total es {total12} ");
        break;
    case 13:
        Console.WriteLine("Ejercicio 13");
        int i13 = 0;
        int num13;
        do
        {
            Console.WriteLine("Ingrese un numero");
            num13 = int.Parse(Console.ReadLine());
            i13++;

        }
        while (num13 != 0);
        Console.WriteLine($"Se ingresaron {i13} numeros");
        break;
    case 14:
        Console.WriteLine("Ejercicio 14");
        int num14 = 0;
        int mayor = 0;
        do
        {
            Console.WriteLine("Ingrese un numero");
            num14 = int.Parse(Console.ReadLine());
            if (num14 > mayor)
            {
                mayor = num14;
            }
        }
        while (num14 != 0);
        Console.WriteLine($"El numero mayor es {mayor}");
        break;
    case 15:
        Console.WriteLine("Ejercicio 15");
        int num15 = 0;
        do
        {
            Console.WriteLine("Ingrese un numero");
            num15 = int.Parse(Console.ReadLine());
        }
        while (num15 <= 1);
        Console.WriteLine("El numero es positivo");
        break;
    case 16:
        Console.WriteLine("Ejercicio 16");
        string pass;
        do
        {
            Console.WriteLine("Ingrese");
            pass = Console.ReadLine();
        }
        while (pass != "contra123");
        Console.WriteLine("Contraseña correcta");
        break;
    case 17:
        Console.WriteLine("Ejercicio 17");
        int num17;
        int i17 = 0;
        do
        {
            Console.WriteLine("Ingrese un numero");
            num17 = int.Parse(Console.ReadLine());
            if (num17 % 2 == 0)
            {
                i17++;
            }
        }
        while (num17 != 0);
        Console.WriteLine($"Se ingresaron {i17} numeros pares");
        break;
    case 18:
        Console.WriteLine("Ejercicio 18");
        int opcion18;
        do
        {
            Console.WriteLine("Seleccione una opción");
            Console.WriteLine("1 Mostrar saludo\r\n2 Mostrar número aleatorio\r\n0 Salir");
            opcion18 = int.Parse(Console.ReadLine());
            switch (opcion18)
            {
                case 1:
                    Console.WriteLine("Hola");
                    break;
                case 2:
                    Random aleatorio = new Random();
                    int numero = aleatorio.Next(1, 11);
                    Console.WriteLine($"Número aleatorio: {numero}");
                    break;
                case 0:
                    Console.WriteLine("Saliendo ....");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (opcion18 != 0);
        Console.WriteLine("Programa finalizado");
        break;
    case 19:
        Console.WriteLine("Ejercicio 19");
        int num19;
        int i19 = 1;
        Console.WriteLine("Ingrese un numero");
        num19 = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine($"{num19} * {i19} = {num19 * i19}");
            i19++;
        }
        while (i19 <= 10);
        break;
    case 20:
        Console.WriteLine("Ejercicio 20");
        int num20;
        int i20 = 0;
        int total20 = 0;
        int opcion20 = 0;
        do
        {
            Console.WriteLine("Ingrese un numero");
            num20 = int.Parse(Console.ReadLine());
            total20 = total20 + num20;
            i20++;
        }
        while (num20 != 0);
        Console.WriteLine($"La suma fue de {total20}");
        Console.WriteLine($"Se ingresaron {i20} numeros ");
        Console.WriteLine($"El promedio fue de {total20 / i20}");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}