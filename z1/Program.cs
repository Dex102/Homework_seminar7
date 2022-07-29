double[,] SquareArray(int m, int n)
{   
    double[,] array = new double[m,n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = Math.Round(new Random().NextDouble() * 10, 1);

    return array;
}

void ShowArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
        }
}

Console.Write("Input row count: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input column count: ");
int column = Convert.ToInt16(Console.ReadLine());

ShowArray(SquareArray(row,column));
