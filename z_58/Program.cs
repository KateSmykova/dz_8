int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int size = InputInt("Задайте размер матриц: ");
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
FillArrayRandomNumbers(matrix1);
FillArrayRandomNumbers(matrix2);
int[,] matrix3 = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
PrintArray(matrix3);