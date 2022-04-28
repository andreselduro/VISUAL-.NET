// See https://aka.ms/new-console-template for more information
Console.WriteLine($"ingrese sus primera calificaciones");
float num1= float.Parse(Console.ReadLine());
Console.WriteLine($"ingrese sus segunda calificaciones");
float num2 = float.Parse(Console.ReadLine());
Console.WriteLine($"ingrese sus tercera calificaciones");
float num3 = float.Parse(Console.ReadLine());
Console.WriteLine($"ingrese sus cuarta calificaciones");
float num4 = float.Parse(Console.ReadLine());
Console.WriteLine($"ingrese sus quinta calificaciones");
float num5 = float.Parse(Console.ReadLine());
float promedio = (num1 + num2 + num3 + num4 + num5) / 5;

if (promedio < 3.0)
{
    Console.WriteLine("DESAPROBO");
}
else
{
    Console.WriteLine("APROBO");
}



