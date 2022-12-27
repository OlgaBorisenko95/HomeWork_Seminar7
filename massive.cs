int[,] Array(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < b; i++)
    {
        for (int j = 0; j < a; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}
void PositionSearch(int[,] array, int a, int b)
{
    if (a > array.GetLength(0) || b > array.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
    else Console.WriteLine("В указанной позиции число " + array[a - 1, b - 1]);
}
Console.Write("Введите число строк массива: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int b = int.Parse(Console.ReadLine());
int[,] array = Array(a, b);

Console.Write("Введите номер cтроки массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца массива: ");
int columns = int.Parse(Console.ReadLine());
PositionSearch(array, rows, columns);
