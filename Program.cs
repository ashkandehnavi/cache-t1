// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Enter 2 numbers...");

while (true)
{
    try
    {
        Console.WriteLine("enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Sum: {a + b}");
        Console.WriteLine($"========================");
    }
    catch (Exception ex)
    {
        Console.WriteLine("enter valid number!");
    }
}



