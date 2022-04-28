
Console.WriteLine("ingrese su primer numero");
 int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese su segundo numero");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese su tercer numero");
int numero3 = int.Parse(Console.ReadLine());

 if (numero1>numero2)
{
    if (numero2>numero3)
    {
        Console.WriteLine($"los numeros en orden decendente son {numero1},{numero2},{numero3}");
    }
    else if (numero1>numero3)
        {
        Console.WriteLine($"los numeros en orden decendente son {numero1},{numero3},{numero2}");
    }
    else
    {
        Console.WriteLine($"los numeros en orden decendente son {numero3},{numero1},{numero2}");
    }
}
 else
{
    if (numero1> numero3 )
    {
        Console.WriteLine($"los numeros en orden decendente son {numero2},{numero1},{numero3}");
    }

    else if ( numero3>numero2)
       {
        Console.WriteLine($"los numeros en orden decendente son {numero3},{numero2},{numero1}");
    }
    else
    {
        Console.WriteLine($"los numeros en orden decendente son {numero2},{numero3},{numero1}");
    }
}
