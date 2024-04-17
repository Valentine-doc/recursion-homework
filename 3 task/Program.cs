//Задание 3

class Program
{
    static void Main()
    {
        int[] array = {8, 6, 12, 24, 3 }; 
        PrintArray(array, array.Length - 1);
    }

    static void PrintArray(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " " );
            PrintArray(array, index - 1);
        }
    }
}
