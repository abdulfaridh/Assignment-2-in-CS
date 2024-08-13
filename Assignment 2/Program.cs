// See https://aka.ms/new-console-template for more information
class Assignment2
{
    static void Main(string[] args)
    {
        float a,b;
        Console.WriteLine("enter two floating point nums:");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
}
