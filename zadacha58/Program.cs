// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

ArrayRandom(array);
mas(array);

Console.WriteLine();

ArrayRandom(secondArray);
mas(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

mas(resultArray);



//----------------------Метод-----------------
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void mas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}