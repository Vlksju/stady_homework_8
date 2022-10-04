Console.WriteLine("Программа, которая элементы трехмерного массива вместе с их индексами");

int[,,] FillRandomDoubleArray(int lines = 2, int columns = 2, int volume = 2, int leftRange = 10, int rethRange = 98)
{
    int[,,] randomArray = new int[lines, columns, volume];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray.GetLength(2); k++)
                randomArray[i, j, k] = rand.Next(leftRange, rethRange + 1);
        }
    }
    return randomArray;
}

void PrintMatrix(int[,,] matrix)


{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write(matrix[i, j, k] + " " + "(" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine();
    }
}


int[,,] arrayOne = FillRandomDoubleArray();

Console.WriteLine("Массив: ");

PrintMatrix(arrayOne);

