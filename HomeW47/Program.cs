double[,] array = new double[3, 4];
Random rnd = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = rnd.NextDouble() * 20 - 10;
    }
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}