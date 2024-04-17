//Задание 2

class Program
{
    static void Main()
    {
        int m, n, result;
        
        Console.WriteLine("Введите  m:");
        m = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите  n:");
        n = int.Parse(Console.ReadLine());
        
        result = CalculateAckermannFunc(m, n);
        
        Console.WriteLine($"Результат функции : {result}");
    }

    static int CalculateAckermannFunc(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        
        if (m > 0 && n == 0)
        {
            return CalculateAckermannFunc(m - 1, 1);
        }
        
        return CalculateAckermannFunc(m - 1, CalculateAckermannFunc(m, n - 1));
    }
}
