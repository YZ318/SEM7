int[,] array = new int[3, 4] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine());

if (row < 0 || row >= array.GetLength(0) || col < 0 || col >= array.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine("Значение элемента: " + array[row, col]);
}
