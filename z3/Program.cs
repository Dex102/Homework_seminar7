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

void SrArifm (int[,] array)
{
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;

        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j,i];
        }

        Console.Write(sum / array.GetLength(1) + " ");
    }
   
}

int[,] MyArray = SquareArray(5,5);

ShowArray(MyArray);

Console.WriteLine("SRARIFM");
SrArifm(MyArray);