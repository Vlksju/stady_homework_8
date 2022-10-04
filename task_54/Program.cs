Console.WriteLine("Программа, которая сортирует элементы каждой строки по возрастанию");

int[,] FillRandomDoubleArray(int lines = 3, int columns = 3, int leftRange = 0, int rethRange = 9)
{
    int[,] randomArray = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = rand.Next(leftRange, rethRange + 1);
        }
    }
    return randomArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillRandomDoubleArray();

Console.WriteLine("Исходный массив: ");

PrintMatrix(array);

int[,] SortingAscending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp;

            if (array[i, j] > array[i, j + 1])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }




        }
    }

    return array;
}


Console.WriteLine();

Console.WriteLine("Новый массив:");

PrintMatrix(SortingAscending(array));





