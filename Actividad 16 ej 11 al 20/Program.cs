Console.WriteLine("Actividad 11 ej 11 al 20");
Console.WriteLine("Ej ");
Console.WriteLine("Elija una opción:");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 11:
        Console.WriteLine("Ejercicio 11");
        int total11 = 0;
        int i11=1;
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
        while (num12 !=0);
        Console.WriteLine($"El total es {total12} ");
        break;
    case 13:
        Console.WriteLine("Ejercicio 13");
        int i13 = 0;
        int num13;
        do
        { Console.WriteLine("Ingrese un numero");
             num13 = int.Parse(Console.ReadLine());
            i13++;

        }
        while (num13 != 0);
        Console.WriteLine($"Se ingresaron {i13} numeros");
        break;
    case 14:
        Console.WriteLine( "Ejercicio 14");
        int num14=0;
        int mayor=0;
        do
        {   Console.WriteLine("Ingrese un numero");
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
        int num15=0;
        do 
            { Console.WriteLine("Ingrese un numero");
                num15 = int.Parse(Console.ReadLine());
            }
        while (num15 <= 1);
        Console.WriteLine("El numero es positivo");
        break;
}