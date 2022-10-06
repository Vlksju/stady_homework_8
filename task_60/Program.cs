Console.WriteLine("Программа, которая выводит элементы трехмерного массива вместе с их индексами");

int[] FillRandomDoubleArray(int lines = 8, int leftRange = 0, int rethRange = 98)
{
    int[] numbersRandom = new int[lines];
    Random rand = new Random();
    for (int i = 0; i < numbersRandom.Length; i++)
    {
        numbersRandom[i] = rand.Next(leftRange, rethRange + 1);
    }
    return numbersRandom;
}

int[] numbers = FillRandomDoubleArray();

int maxNumber = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] == numbers[j])
        {
            maxNumber++;
            numbers[j] = maxNumber;
        }
    }
}


int[,,] arrayOne = new int[2, 2, 2];
int p = 0;

for (int i = 0; i < arrayOne.GetLength(0); i++)
{  
    for (int j = 0; j < arrayOne.GetLength(1); j++)
    {

        for (int k = 0; k < arrayOne.GetLength(2); k++)
        {


            arrayOne[i, j, k] = numbers[p];
            p++;
          
        }
   
    } 
   
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

Console.WriteLine("Массив: ");

PrintMatrix(arrayOne);

