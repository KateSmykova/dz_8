Console.Write("Введите размер массива: ");
int massive = Convert.ToInt32(Console.ReadLine());

int[,] num = new int[massive, massive];

FillArrayRandomNumbers(num);
PrintArray(num);

int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < num.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + num[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("минимальная сумма элементов в строке: " 
+ (indexLine) + ", в которой сумма элементов равна: " + (minsum));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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