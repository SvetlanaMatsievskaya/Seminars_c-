int number_a = 0;
Console.Write("Enter number a: ");

number_a = int.Parse(Console.ReadLine());

int number_b = 0;

Console.Write("Enter number b: ");

number_b = int.Parse(Console.ReadLine());

int number_c = 0;

Console.Write("Enter number c: ");

number_c = int.Parse(Console.ReadLine());

if (number_a> number_b)
{
    
    if (number_a>number_c)
    
    {
        Console.WriteLine($"max = {number_a}");
    }
    
    else
    {
        Console.WriteLine($"max = {number_c}");
    }
}
else if (number_a< number_b)
{
    if (number_b>number_c)
    {
        Console.WriteLine($"max = {number_b}");
    }
    else
    {
        Console.WriteLine($"max = {number_c}");
    }
}

