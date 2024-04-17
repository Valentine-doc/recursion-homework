//Задание 1

class Program
{
    static void Main()
    {
        int m, n;

        Console.WriteLine("Введите  M:");
        m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите  N:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Натуральные числа: ");

        FindNaturalNumbers(m, n);
    }

    static void FindNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + "\t");

            FindNaturalNumbers(m + 1, n);
        }
    }
}
