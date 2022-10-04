Console.WriteLine("Программа, которая находит строку с наименьшей суммой элементов");

int[,] FillRandomDoubleArray(int lines = 4, int columns = 3, int leftRange = 0, int rethRange = 9)
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

Console.WriteLine();

int[] matrix = new int[array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)

    {
        sum = sum + array[i, j];

    }

    matrix[i] = sum;
}

int min = matrix[0];

int minI = 0;

for (int i = 0; i < matrix.Length; i++)
{
    if (matrix[i] < min)
    {
        min = matrix[i];
        minI = i + 1;

    }
}

Console.WriteLine($"Номер строки с наименьшей суммй элементов {minI}");






