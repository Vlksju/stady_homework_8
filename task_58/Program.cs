Console.WriteLine("Программа, которая находит произведение двух матриц");

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


int[,] arrayOne = FillRandomDoubleArray();

Console.WriteLine("Исходный массив 1: ");

PrintMatrix(arrayOne);

Console.WriteLine();


int[,] arrayTwo = FillRandomDoubleArray();

Console.WriteLine("Исходный массив 2: ");

PrintMatrix(arrayTwo);

Console.WriteLine();

int[,] arrayResult = new int[arrayOne.GetLength(0),arrayTwo.GetLength(1)];

for (int i = 0; i < arrayOne.GetLength(0); i++)
{
    for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayResult[i, j] = arrayOne[i, j] * arrayTwo[i,j];
        }
    }

Console.WriteLine("Результат: ");

PrintMatrix(arrayResult);

