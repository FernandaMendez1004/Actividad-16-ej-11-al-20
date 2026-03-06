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


}