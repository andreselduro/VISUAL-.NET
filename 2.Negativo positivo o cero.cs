// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese un numero");
double  numero = double.Parse(Console.ReadLine());
if (numero == 0)
{
    Console.WriteLine("neutro");
}
else if (numero > 0)
{
    Console.WriteLine("positivo");
}
else
{
    Console.WriteLine("negativo");
}
