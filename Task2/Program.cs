int number_a = 0;
Console.Write("Enter number a: ");

string userEnter_a = Console.ReadLine();

number_a = int.Parse(userEnter_a);

int number_b = 0;

Console.Write("Enter number b: ");

string userEnter_b = Console.ReadLine();

number_b = int.Parse(userEnter_b);

if (number_a> number_b)
{
    Console.WriteLine($"max = {number_a}");
}
else
{
    Console.WriteLine($"max = {number_b}");

}