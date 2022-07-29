int[,] SquareArray(int m, int n)
{   
    int[,] array = new int[m,n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random().Next(1, 10);

    return array;
}

void ShowArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
        }
}

int IndexesOfArray(int m, int n, int[,] array)
{
    int number = array[m,n];
    return number;
}

Console.Write("Input row count: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input column count: ");
int column = Convert.ToInt16(Console.ReadLine());

int[,] NewArray = SquareArray(row, column);

ShowArray(NewArray);

Console.Write(IndexesOfArray(1, 4, NewArray));

