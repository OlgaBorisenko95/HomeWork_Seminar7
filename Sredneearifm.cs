int[,] Array(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}
void MiddleColumns(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double countLine = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            countLine = countLine + array[j, i];
        }
        Console.Write(Math.Round(countLine / array.GetLength(0), 1) + ",   ");
    }
}
Console.Write("Введите число строк массива: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int b = int.Parse(Console.ReadLine());
MiddleColumns(Array(a, b));
