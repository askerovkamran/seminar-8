// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] table = new int[4, 4];
Array(table);
PrintArray(table);
Console.WriteLine();
sumel(table);


// -------------------------Метод-------------------
void sumel(int[,] array)
{
    int min = 0;
    int mins = 0;
    int sum = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        min += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sum += table[i, j];
        if (sum < min)
        {
            min = sum;
            mins = i;
        }
        sum = 0;
    }
    Console.Write($"{mins + 1} строка");
}

void PrintArray(int[,] array)
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


void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}