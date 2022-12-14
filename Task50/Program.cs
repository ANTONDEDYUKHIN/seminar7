/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет       */
Console.Clear();
Console.Write("Введите адрес строки a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите адрес столбца b: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы col
        {
            matrix[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
           else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
}
void FindPosMatrix(int[,] matrix)
{
    int c = a - 1;
    int d = b - 1;
if (c > 0 & c < matrix.GetLength(0)
 && d > 0 && d < matrix.GetLength(1)) Console.WriteLine($"Значение элемента массива = {matrix [c, d]}");
    else
    {
        Console.WriteLine("Элемент не существует");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2D);
FindPosMatrix(array2D);
