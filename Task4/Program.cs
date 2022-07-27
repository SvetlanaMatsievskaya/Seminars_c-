int number_a = 0;
Console.Write("Enter number a: ");

number_a = int.Parse(Console.ReadLine());

int number_b = 0;

Console.Write("Enter number b: ");

number_b = int.Parse(Console.ReadLine());

int number_c = 0;

Console.Write("Enter number c: ");

number_c = int.Parse(Console.ReadLine());

int max_number = number_a;

if (number_b> max_number)
{
        max_number = number_b;
}
if (number_c> max_number)   
   {
    max_number = number_c;
   }
Console.WriteLine($"max = {max_number}");
